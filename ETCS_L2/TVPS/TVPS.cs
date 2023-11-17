using eng;
using infra;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CCSTMS.ETCS_L2_Planning
{
    /// <summary>
    /// A Class to plan a TVPS according to Generic engineering rules document dated 6-15-2023
    /// </summary>
    public class TVPS
    {
        /// <summary>
        /// plan TVPS sections on the whole tracks avalaible.
        /// </summary>
        /// <param name="infra"></param>
        /// <param name="engArea"></param>
        public void Plan(Infrastructure infra, EngArea engArea)
        {
            if (infra == null || engArea == null) return; //both are required to plan.

            TVPS_SimplePoint(infra, 0, engArea);
            TVPS_RestOfTracks(infra,0);
        }

        #region around Points
        /// <summary>
        /// Plan TVPS around SimplePoints
        /// </summary>
        /// <param name="infra"></param>
        /// <param name="funcAreaIndex"></param>
        /// <param name="topoAreaIndex"></param>
        /// <param name="mapAreaIndex"></param>
        /// <param name="engArea"></param>
        private void TVPS_SimplePoint(Infrastructure infra, int funcAreaIndex, EngArea engArea)
        {
            uint overHung = 5000;

            var simplePoints = infra.functionalAreas[funcAreaIndex].simplePoints;

            infra.functionalAreas[funcAreaIndex].trainDetectors ??= new(); //if no train detectors container create one.

            

            foreach (var simplePoint in simplePoints)
            {
                var tvps = new TvpSection() { id = Guid.NewGuid().ToString(), trainDetectors = new(), trackSections = new() };
                //get trackEdges around the simplePoint.
                var trackEdges = Help.SimplePointTrackEdges(infra, simplePoint);

                // get danger points along these edges.
                var dangerPoints = engArea.dangerPoints
                    .Where(x => engArea.simplePoints.Where(y=>y.id.Equals(simplePoint.id)).SelectMany(y => y.dangerPoints).Select(z=>z.Ref).Contains(x.id));


                foreach (var trackEdge in trackEdges)
                {
                    // track edge start beside the simple point or no.
                    var start = infra.topoAreas.SelectMany(x => x.trackEdgeLinks)
                        .Where(x => x.id.Equals(simplePoint.branchTrack) || x.id.Equals(simplePoint.mainTrack))
                        .Where(x=>x.trackEdgeA.Equals(trackEdge.id)||x.trackEdgeB.Equals(trackEdge.id))
                        .Select(x =>
                        {
                            if (x.trackEdgeA.Equals(trackEdge.id)) return x.startOfA;
                            return x.startOfB;
                        }).First();

                    //if the trackEdge have a danger point.
                    var dangerPoint = dangerPoints.Where(x => x.trackEdge.Equals(trackEdge.id)).FirstOrDefault();

                    var dangerPointP = dangerPoint != null? dangerPoint.pos : 0;

                    uint trainDetectorP = 0;

                    // trackedge start beside the simplePoint
                    if (start)
                    {
                        trainDetectorP = dangerPointP + overHung;
                        tvps.trackSections.Add(new() {

                            trackEdge=trackEdge.id,
                            skipFromPathStart= Help.SkipFromStart(0, trainDetectorP),
                            skipFromPathEnd = Help.SkipFromEnd(0, trainDetectorP,trackEdge)
                        });
                    }
                    else
                    {
                        if (dangerPointP==0)
                        {
                            trainDetectorP = trackEdge.length  - overHung;
                        }
                        else
                        {
                            trainDetectorP = dangerPointP - overHung;
                        }
                        
                        tvps.trackSections.Add(new()
                        {

                            trackEdge = trackEdge.id,
                            skipFromPathStart = Help.SkipFromStart(trackEdge.length, trainDetectorP),
                            skipFromPathEnd = Help.SkipFromEnd(trackEdge.length, trainDetectorP, trackEdge)
                        });
                    }

                    var trainDetector = new TrainDetector()
                    {
                        id = Guid.NewGuid().ToString(),
                        trackEdge = trackEdge.id,
                        type = TrainDetectorType.axleCounter,
                        pos = trainDetectorP
                    };
                    infra.functionalAreas[funcAreaIndex].trainDetectors.Add(trainDetector);
                    tvps.trainDetectors.Add(new() {Ref = trainDetector.id } );
                }
                infra.functionalAreas[funcAreaIndex].tvps.Add(tvps);
            }
        }
        #endregion

        #region rest of tracks
        /// <summary>
        /// Design TVPS for spaces not around simple points.
        /// </summary>
        /// <param name="infra"></param>
        /// <param name="funcArea"></param>
        private void TVPS_RestOfTracks(Infrastructure infra, int funcAreaIndex)
        {
            var currentTVPS = infra.functionalAreas.SelectMany(x => x.tvps);

            var currentTVPSsections = currentTVPS.SelectMany(x => x.trackSections);

            //each track with the sections on it from the TVPS
            var currentSectionsOnTracks = infra.topoAreas.SelectMany(x => x.trackEdges).GroupJoin(currentTVPSsections, x => x.id, y => y.trackEdge,
                (x,sections) => new // resultSelector 
                {
                    key = x,
                    sections = sections
                });

            foreach (var item in currentSectionsOnTracks)
            {
                var trackEdge = item.key;
                var occupiedSections = item.sections.ToList();
                var emptySections = GetEmptySections(occupiedSections, trackEdge);

                foreach (var emptySection in emptySections)
                {
                    var tvps = new TvpSection() { id = Guid.NewGuid().ToString(), trainDetectors = new(), trackSections = new() };
                    tvps.trackSections.Add(new() {
                        
                        trackEdge=trackEdge.id,
                        skipFromPathStart = emptySection.Item1,
                        skipFromPathEnd = trackEdge.length - emptySection.Item2,

                       });

                    var avalaibleTrainDetector = infra.functionalAreas.SelectMany(x => x.trainDetectors).Where(x => x.trackEdge.Equals(trackEdge.id));
                    
                    var atStart = avalaibleTrainDetector.Where(x => x.pos.Equals(emptySection.Item1)).FirstOrDefault();
                    var atEnd = avalaibleTrainDetector.Where(x => x.pos.Equals(emptySection.Item2)).FirstOrDefault();

                    if (atStart != null)
                    {
                        tvps.trainDetectors.Add(new() { Ref = atStart.id});
                    }
                    
                    if (atEnd != null)
                    {
                        tvps.trainDetectors.Add(new() { Ref = atEnd.id });
                    }   

                        
                   if (atStart==null)
                   {
                       var trainDetector = new TrainDetector()
                       {
                           id = Guid.NewGuid().ToString(),
                           trackEdge = trackEdge.id,
                           type = TrainDetectorType.axleCounter,
                           pos = emptySection.Item1
                       };
                       infra.functionalAreas[funcAreaIndex].trainDetectors.Add(trainDetector);
                   }

                   if (atEnd == null)
                   {
                       var trainDetector = new TrainDetector()
                       {
                           id = Guid.NewGuid().ToString(),
                           trackEdge = trackEdge.id,
                           type = TrainDetectorType.axleCounter,
                           pos = emptySection.Item2
                       };
                       infra.functionalAreas[funcAreaIndex].trainDetectors.Add(trainDetector);
                   
                    }
                    infra.functionalAreas[funcAreaIndex].tvps.Add(tvps);
                }
            }
        }

        /// <summary>
        /// Get an empty sections along the trackEdge based on specific sections avalaible on that edge.
        /// </summary>
        /// <param name="sections"></param>
        /// <param name="trackEdge"></param>
        /// <returns></returns>
        private IEnumerable<(uint,uint)> GetEmptySections(List<TrackEdgeSection> sections, TrackEdge trackEdge)
        {
            var orderedSections = sections.OrderBy(x => x.skipFromPathStart);
            var starts = orderedSections.Select(x => x.skipFromPathStart).Append((uint)trackEdge.length);
            var ends = orderedSections.Select(x => trackEdge.length - x.skipFromPathEnd).Prepend((uint)0);

            var freeSections = starts.Select((x, i) =>  (ends.ElementAt(i), x)).Where(x =>x.Item2 != x.Item1);
            freeSections = freeSections.SelectMany(x=>Divide(x));

            return freeSections;
        }

        /// <summary>
        /// Divide a section into smaller pieces according to maximum length for a section.
        /// </summary>
        /// <param name="section"></param>
        /// <param name="MaxLength"></param>
        /// <returns></returns>
        private List<(uint, uint)> Divide((uint, uint) section,uint MaxLength = 500000)
        {
            var difference = (double)section.Item2 - (double)section.Item1;
            if (difference> MaxLength)
            {
                List<(uint, uint)> division = new();
                var remainder = difference / MaxLength;
                var intValue = (int)Math.Floor(remainder);
                var startValue = section.Item1;
                for (int i = 0; i < intValue; i++)
                {
                    division.Add((startValue,startValue+MaxLength));
                    startValue = startValue + MaxLength;
                }
                division.Add((startValue, section.Item2));
                return division;
            }
            return new() { section };
        }
        #endregion
    }
    
}
