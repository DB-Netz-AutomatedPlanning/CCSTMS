using eng;
using Geometry;
using infra;
using System;
using System.Collections.Generic;
using System.Linq;
using BaliseGroup = infra.BaliseGroup;

namespace CCSTMS.ETCS_L2_Planning
{
    /// <summary>
    /// A Class to plan a BaliseGroups according to Generic engineering rules document dated 6-15-2023
    /// </summary>
    public class BaliseGroups
    {
        public void Plan(Infrastructure infra, EngArea engArea)
        {
            infra.functionalAreas[0].baliseGroups = new List<BaliseGroup>();

            BaliseGroup_DangerPoint(infra, engArea);
            BaliseGroup_BufferStops(infra);
            BaliseGroup_each2000Meters(infra);
        }

        #region BaliseGroup_BufferStop
        /// <summary>
        /// Place BaliseGroups before the buffer stops.
        /// </summary>
        /// <param name="infra"></param>
        /// <param name="engArea"></param>
        private static void BaliseGroup_BufferStops(Infrastructure infra)
        {
            var bufferStop = infra.functionalAreas[0].bufferStops;

            foreach (var item in bufferStop)
            {

                var trackEdgeProjection = infra.mapAreas[0].trackEdges.Find(x => x.id.Equals(item.trackEdge));

                BaliseGroup BG = new() { id = Guid.NewGuid().ToString(), balises = new() { new() { trackEdge = trackEdgeProjection.id  } } };

                if (HelperFunctions.DecideWithDirectionToMove(trackEdgeProjection, item.pos))
                {
                    BG.balises[0].pos = item.pos + 0;
                }
                else
                {

                    BG.balises[0].pos = item.pos - 0;

                }
                var coordinate = HelperFunctions.GetCoordinatesFromP(trackEdgeProjection, BG.balises[0].pos);
                BaliseGroup_Project(coordinate, BG, infra);

                infra.functionalAreas[0].baliseGroups.Add(BG);
            }
        }
        #endregion

        #region BaliseGroup_DangerPoint
        /// <summary>
        /// Place BaliseGroups before danger points opposite to the direction of simple point.
        /// </summary>
        /// <param name="infra"></param>
        /// <param name="funcArea"></param>
        /// <param name="engArea"></param>
        private void BaliseGroup_DangerPoint(Infrastructure infra, EngArea engArea)
        {
            BaliseGroup_DangerPoint_for_SimplePoints(infra,engArea);



        }

        private void BaliseGroup_DangerPoint_for_SimplePoints(Infrastructure infra, EngArea engArea)
        {
            uint baliseShift = 3000;
            uint baliseSpacing = 2300;

            var dangerPoints = engArea.dangerPoints.Where(x => engArea.simplePoints.SelectMany(y => y.dangerPoints).Select(x => x.Ref).Contains(x.id));
            foreach (var dangerPoint in dangerPoints)
            {
                var simplePointEng = engArea.simplePoints.Where(x => x.dangerPoints.Select(y => y.Ref).Contains(dangerPoint.id)).FirstOrDefault();
                var simplePoint = infra.functionalAreas.SelectMany(x => x.simplePoints).Where(x => x.id.Equals(simplePointEng?.id)).FirstOrDefault();
                // track edge start beside the simple point or no.
                var start = infra.topoAreas.SelectMany(x => x.trackEdgeLinks)
                    .Where(x => x.id.Equals(simplePoint.branchTrack) || x.id.Equals(simplePoint.mainTrack))
                    .Where(x => x.trackEdgeA.Equals(dangerPoint.trackEdge) || x.trackEdgeB.Equals(dangerPoint.trackEdge))
                    .Select(x =>
                    {
                        if (x.trackEdgeA.Equals(dangerPoint.trackEdge)) return x.startOfA;
                        return x.startOfB;
                    }).First();

                BaliseGroup baliseGroup = new()
                {
                    id = Guid.NewGuid().ToString(),
                    bgFunction = BaliseGroupFunction.location,
                    balises = new()
                };

                infra.functionalAreas[0].baliseGroups.Add(baliseGroup);

                var trackEdge = infra.topoAreas.SelectMany(x => x.trackEdges).Where(x => x.id.Equals(dangerPoint.trackEdge)).FirstOrDefault();

                var dangerPointP = dangerPoint != null ? dangerPoint.pos : 0;

                uint firstBaliseP = 0;

                // trackedge start beside the simplePoint
                if (start)
                {
                    firstBaliseP = dangerPointP + baliseShift;

                    baliseGroup.balises.Add(new() { id = Guid.NewGuid().ToString(), trackEdge = trackEdge.id, pos = firstBaliseP });
                    baliseGroup.balises.Add(new() { id = Guid.NewGuid().ToString(), trackEdge = trackEdge.id, pos = firstBaliseP + baliseSpacing });
                }
                else
                {
                    if (dangerPointP == 0)
                    {
                        firstBaliseP = trackEdge.length - baliseShift;
                    }
                    else
                    {
                        firstBaliseP = dangerPointP - baliseShift;
                    }
                    baliseGroup.balises.Add(new() { id = Guid.NewGuid().ToString(), trackEdge = trackEdge.id, pos = firstBaliseP });
                    baliseGroup.balises.Add(new() { id = Guid.NewGuid().ToString(), trackEdge = trackEdge.id, pos = firstBaliseP - baliseSpacing });
                }
            }
        }
        #endregion

        #region BaliseGroup_each2000Meters

        /// <summary>
        /// Place BaliseGroups each 2000 meters along any path that train can take.
        /// </summary>
        /// <param name="infra"></param>
        /// <param name="engArea"></param>
        private void BaliseGroup_each2000Meters(Infrastructure infra)
        {
            var allTrackLinks = infra.topoAreas[0].trackEdgeLinks.Select(x => x);
            var paths = GetAllPaths(allTrackLinks, infra);
            paths.ForEach(x => MoveAlongThePath(x, infra, 2000000));

        }

        /// <summary>
        /// move through a path and check if there is a BG each 2000 meter 
        /// </summary>
        private void MoveAlongThePath(SD1_Path path, Infrastructure infra, uint increment)
        {

            //they are sorted as the path input.
            var TrackEdgeProjections = new List<TrackEdgeProjection>();

            path.path.ForEach(x =>
            {

                var projection = infra.mapAreas[0].trackEdges
                .Where(y => y.id.Equals(x))
                .Select(y => y).FirstOrDefault();

                TrackEdgeProjections.Add(projection);
            });

            uint distance = 20000;
            uint currentMaxLength = 0;
            uint currentMinLength = 0;
            foreach (var projection in TrackEdgeProjections)
            {
                currentMaxLength += projection.coordinates[projection.coordinates.Count - 1].pos;

                while (distance < currentMaxLength)
                {

                    var PonTrack = distance - currentMinLength;
                    PonTrack = PonTrack < 0 ? 0 : PonTrack;
                    var coverd = CheckRelocationBGOnTrackEdge(PonTrack, increment, projection, infra);

                    if (!coverd) PlaceRelocationBalise(projection, PonTrack, infra);
                    distance += increment;
                }

                currentMinLength += projection.coordinates[projection.coordinates.Count - 1].pos;
            }
        }

        /// <summary>
        /// check if there is already a relocation baliseGroup on that track.
        /// </summary>
        /// <param name="porposedPosition"></param>
        /// <param name="increment"></param>
        /// <param name="projection"></param>
        /// <param name="infra"></param>
        /// <returns></returns>
        private bool CheckRelocationBGOnTrackEdge(uint porposedPosition, uint increment, TrackEdgeProjection projection, Infrastructure infra)
        {

            var avalaibleBG = infra.functionalAreas[0].baliseGroups
                .SelectMany(x => x.balises.Select(y => y))
                .Where(x => x.trackEdge.Equals(projection.id) && Math.Abs(porposedPosition - (double)x.pos) < increment)
                .Select(x => x);

            return avalaibleBG.Count() > 0;
        }
        /// <summary>
        /// place a relocation Balise on the track according to a specific p value.
        /// </summary>
        /// <param name="projection"></param>
        /// <param name="p"></param>
        /// <param name="infra"></param>
        private void PlaceRelocationBalise(TrackEdgeProjection projection, uint p, Infrastructure infra)
        {
            //check if there is one near.
            var avalaibleBG = infra.functionalAreas[0].baliseGroups.Where(x => x.balises.Select(y => y.trackEdge).Contains(projection.id)).Select(x => x);

            if (avalaibleBG.Any())
            {


            }

            // if relocation Balise in near. add one
            var baliseGroup = new BaliseGroup() { id = Guid.NewGuid().ToString(), balises = new(), bgFunction = BaliseGroupFunction.location };

            

            infra.Balise b1 = new() { id = Guid.NewGuid().ToString(), trackEdge = projection.id, pos = p };
            infra.Balise b2 = new() { id = Guid.NewGuid().ToString(), trackEdge = projection.id, pos = p };

            baliseGroup.balises.Add(b1);
            baliseGroup.balises.Add(b2);

            //selection of balise type to be adjusted.
            eng.Balise b1_eng = new() { id = b1.id, standardSize = true };
            eng.Balise b2_eng = new() { id = b2.id, standardSize = true };

            var speed = HelperFunctions.GetSpeedOnTrackatP(infra, projection, p);
            var distance = BalisesMinimumDistance(speed, b2_eng);
            b2.pos += distance / 2; //place the second balise in direction of P increment.
            b1.pos -= distance / 2;

            var shift = BaliseGroup_Shift(speed, baliseGroup, projection, infra);

            b2.pos -= shift / 2; //place the second balise in direction of P increment.
            b1.pos -= shift / 2;

            var coordinate = HelperFunctions.GetCoordinatesFromP(projection, p);
            BaliseGroup_Project(coordinate, baliseGroup, infra);
            infra.functionalAreas[0].baliseGroups.Add(baliseGroup);

        }
        /// <summary>
        /// Minimun distances of balise according to speeds and type.
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="balise"></param>
        /// <returns></returns>
        private uint BalisesMinimumDistance(double speed, eng.Balise balise)
        {
            if (balise.standardSize == true) { return 2600; }
            if (180 < speed && speed <= 300) { return 3200; }
            if (300 < speed && speed <= 500) { return 5000; }
            return 2300;
        }

        /// <summary>
        /// Shift BaliseGroups to keep the 20000 distance or get the best location inbetween.
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="BG"></param>
        /// <param name="projection"></param>
        /// <param name="infra"></param>
        /// <returns></returns>
        private uint BaliseGroup_Shift(double speed, BaliseGroup BG, TrackEdgeProjection projection, Infrastructure infra)
        {
            var midPoint0 = GetBaliseGroupCenter(BG);

            // get any link that have such a track
            var trackEdgeLinks = infra.topoAreas[0].trackEdgeLinks.Where(x => x.trackEdgeA.Equals(projection.id) || x.trackEdgeB.Equals(projection.id));

            var paths = GetAllPaths(trackEdgeLinks, infra);

            List<List<object>> nearestBaliseGroupData = new();
            foreach (var item in paths)
            {
                nearestBaliseGroupData.AddRange(GetNearGroupsOnPath(item, projection, midPoint0, speed, infra));
            }

            var distinct = nearestBaliseGroupData.Distinct(new MyObjectEqualityComparer()).ToList();

            var nearOnes = distinct.Where(x => (double)x[0] < 20000).Select(x => x);

            if (nearOnes.Count() == 1 && distinct.Count == 1)
            {
                var difference = nearOnes.FirstOrDefault()[0];
                var shift = 20000 - (double)difference;
                return (uint)shift;
            }

            if (nearOnes.Count() == 1 && distinct.Count > 1)
            {
                var difference = nearOnes.FirstOrDefault()[0];
                var shift = 20000 - (double)difference;
                return (uint)shift;
            }
            if (nearOnes.Count() == 2 && distinct.Count > 1)
            {
                var sortedAll = distinct.OrderBy(x => x[0]);

                var before = sortedAll.Where(x => (bool)x[1] == false).FirstOrDefault();
                var after = sortedAll.Where(x => (bool)x[1] == true).FirstOrDefault();

                return (uint)((double)before[0] + (double)after[0]) / 2;
            }

            return 0;
        }

        /// <summary>
        /// Get all paths in the data regardless the travelling directions.
        /// </summary>
        /// <param name="trackEdgeLinks"></param>
        /// <param name="infra"></param>
        /// <returns></returns>
        private List<SD1_Path> GetAllPaths(IEnumerable<TrackEdgeLink> trackEdgeLinks, Infrastructure infra)
        {
            if (infra.topoAreas[0].trackEdges.Count == 1)
            {
                return new() { new SD1_Path() { path = new() { infra.topoAreas[0].trackEdges[0].id } } };
            }

            List<TrackEdgeLink> visitedLinks = new();
            List<SD1_Path> paths = new();

            foreach (var item in trackEdgeLinks)
            {
                SD1_Path path = new();

                visitedLinks.Add(item);

                var TrackEdgeA = infra.topoAreas[0].trackEdges.Find(x => x.id.Equals(item.trackEdgeA));
                var TrackEdgeB = infra.topoAreas[0].trackEdges.Find(x => x.id.Equals(item.trackEdgeB));

                //add the trackedges to the path sequenced.
                path.path.Add(TrackEdgeB.id);
                ExtendPath(TrackEdgeB, item.startOfB, path, infra, false, visitedLinks);

                path.path = path.path.Prepend(TrackEdgeA.id).ToList();
                ExtendPath(TrackEdgeA, item.startOfA, path, infra, true, visitedLinks);

                AlignPathDirection(path, infra);

                paths.Add(path);
            }
            return paths;
        }

        /// <summary>
        /// Expand a path in both directions by getting the trackEdgeLinks that contains an edge.
        /// </summary>
        /// <param name="trackEdge"></param>
        /// <param name="startOn"></param>
        /// <param name="path"></param>
        /// <param name="infra"></param>
        /// <param name="append">append or prepend a trackEdge according to is topological connection to the path</param>
        private void ExtendPath(TrackEdge trackEdge, bool startOn, SD1_Path path, Infrastructure infra, bool append, List<TrackEdgeLink> visitedLinks)
        {
            var trackEdgeLink = infra.topoAreas[0].trackEdgeLinks
                .Where(x => (x.trackEdgeA.Equals(trackEdge.id) || x.trackEdgeB.Equals(trackEdge.id)) && !SD1_Path.visitedLinks.Contains(x))
                .Select(x => x)
                .Where(x => x.trackEdgeA.Equals(trackEdge.id) && x.startOfA != startOn || x.trackEdgeB.Equals(trackEdge.id) && x.startOfB != startOn)
                .Select(x => x).FirstOrDefault();


            if (trackEdgeLink == null) return;

            visitedLinks.Add(trackEdgeLink);

            var trackEdgeID = trackEdgeLink.startOfA == startOn ? trackEdgeLink.trackEdgeA : trackEdgeLink.trackEdgeB;

            var TrackEdge = infra.topoAreas[0].trackEdges.Find(x => x.id.Equals(trackEdgeID));

            if (!append) { path.path.Add(TrackEdge.id); } else { path.path = path.path.Prepend(TrackEdge.id).ToList(); };

            if (trackEdgeLink.trackEdgeA.Equals(trackEdgeID)) ExtendPath(TrackEdge, trackEdgeLink.startOfA, path, infra, append, visitedLinks);
            if (trackEdgeLink.trackEdgeB.Equals(trackEdgeID)) ExtendPath(TrackEdge, trackEdgeLink.startOfB, path, infra, append, visitedLinks);
        }

        /// <summary>
        /// Align the direction of the path according to the sequence of stored data.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="infra"></param>
        private void AlignPathDirection(SD1_Path path, Infrastructure infra)
        {
            var first = path.path.First();
            var linkAtTheFirstBeginning = infra.topoAreas[0].trackEdgeLinks.Find(x => x.trackEdgeA.Equals(first) && x.startOfA || x.trackEdgeB.Equals(first) && x.startOfB);

            if (linkAtTheFirstBeginning != null) { path.path.Reverse(); }
        }

        /// <summary>
        /// Get BaliseGroups which is near on the same path.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="projection"></param>
        /// <param name="BGlocation"></param>
        /// <param name="speed"></param>
        /// <param name="infra"></param>
        /// <returns></returns>
        private List<List<object>> GetNearGroupsOnPath(SD1_Path path, TrackEdgeProjection projection, double BGlocation, double speed, Infrastructure infra)
        {
            var baliseGroups = infra.functionalAreas[0].baliseGroups.Where(x => path.path.Contains(x.balises[0].trackEdge));
            List<List<object>> nearGroups = new();
            baliseGroups.ToList().ForEach(x =>
            {

                var midPoint1 = GetBaliseGroupCenter(x);
                if (speed <= 300)
                {
                    var data = GetBaliseGroupLocationAlongPath(path, BGlocation, projection.id, midPoint1, x.balises[0].trackEdge, infra);
                    if ((double)data[0] < 20000)
                    {
                        data.Add(x);
                        nearGroups.Add(data);
                    }
                }

            });
            return nearGroups;
        }

        /// <summary>
        /// Get the BaliseGroup location along a path not only edge.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="location1"></param>
        /// <param name="trackEdge1ID"></param>
        /// <param name="location2"></param>
        /// <param name="trackEdge2ID"></param>
        /// <param name="infra"></param>
        /// <returns></returns>
        private List<object> GetBaliseGroupLocationAlongPath(SD1_Path path, double location1, string trackEdge1ID, double location2, string trackEdge2ID, Infrastructure infra)
        {
            var distance = 0.0;
            var before = false;
            var startCalculate = false;
            var countEdges = 0;
            foreach (var item in path.path)
            {
                if (item.Equals(trackEdge1ID) && !item.Equals(trackEdge2ID))
                {
                    startCalculate = true;
                    var trackEdge = infra.topoAreas[0].trackEdges.Find(x => x.id.Equals(item));
                    distance += trackEdge.length - location1;
                    countEdges += 1;
                }

                if (startCalculate == true && !item.Equals(trackEdge1ID) && !item.Equals(trackEdge2ID))
                {
                    var trackEdge = infra.topoAreas[0].trackEdges.Find(x => x.id.Equals(item));
                    distance += trackEdge.length;
                }

                if (!item.Equals(trackEdge1ID) && item.Equals(trackEdge2ID))
                {
                    if (startCalculate != true) { before = true; }

                    startCalculate = true;
                    var trackEdge = infra.topoAreas[0].trackEdges.Find(x => x.id.Equals(item));
                    distance += (double)location2;
                    countEdges += 1;
                }

                //when both are on the same edge
                if (item.Equals(trackEdge1ID) && item.Equals(trackEdge2ID))
                {
                    if (location1 > location2 != true) { before = true; }
                    startCalculate = true;
                    var trackEdge = infra.topoAreas[0].trackEdges.Find(x => x.id.Equals(item));
                    distance += Math.Abs((double)location2 - (double)location1);
                    countEdges += 2;
                    break;
                }

                if (countEdges == 2) break;
            }

            return new List<object> { distance, before };
        }

        /// <summary>
        /// Get BaliseGroup center.
        /// </summary>
        /// <param name="BG"></param>
        /// <returns></returns>
        private double GetBaliseGroupCenter(BaliseGroup BG)
        {
            var midpoint = BG.balises.Select(x => x.pos).OrderBy(x => x).Sum(x => x) / BG.balises.Count;
            return midpoint;
        }
        #endregion

        #region Misc.
        /// <summary>
        /// Project a BaliseGroup to x,y,z values based on their placement on track.
        /// </summary>
        /// <param name="coordinate"></param>
        /// <param name="BG"></param>
        /// <param name="infra"></param>
        private static void BaliseGroup_Project(Point coordinate, infra.BaliseGroup BG, Infrastructure infra)
        {
            FuncElementProjection projection = new FuncElementProjection() { elementRef = new FuncElementRef() { balise = new BaliseRef() {Ref= BG.id } }, x = coordinate.X, y = coordinate.Y };
            infra.mapAreas[0].funcElements.Add(projection);
        }
        #endregion

    }
}
