using eng;
using infra;
using System;
using System.Collections.Generic;
using System.Linq;
using tp;

namespace CCSTMS.ETCS_L2_Planning
{
    public class TP
    {
        public void PlanAllocationSections(Infrastructure infrastructure,EngArea engArea, TrainProtectionArea TpArea)
        {

            TpArea.allocationSections = new List<AllocationSection>();

            var simplePoints = infrastructure?.functionalAreas.SelectMany(x => x.simplePoints);

            simplePoints?.ToList().ForEach(item => {

                var simplePointProjection = infrastructure?.mapAreas.SelectMany(x => x.funcElements).FirstOrDefault(x => {
                    if (x.elementRef?.simplePoint!=null)
                    {
                        return x.elementRef.simplePoint.Ref.Equals(item.id);
                    }else { return false; }
                });

                var trackEdgesIds = infrastructure?.topoAreas.SelectMany(x => x.trackEdgeLinks)
                    .Where(x => x.id.Equals(item.mainTrack) || x.id.Equals(item.branchTrack))
                    .Select(x => new[] { x.trackEdgeA, x.trackEdgeB }).SelectMany(x => x)
                    .GroupBy(item => item)
                    .Where(group => group.Count() == 1)
                    .Select(group => group.Key);


               

                var dependent = new List<AllocationSection>();

                trackEdgesIds?.ToList().ForEach(trackEdgesId => {

                    var trackProjection = infrastructure?.mapAreas.SelectMany(x => x.trackEdges).First(x => x.id.Equals(trackEdgesId));

                    if (trackProjection == null || simplePointProjection == null) return;

                    uint centerLinesCrossingP = GetNearestP(simplePointProjection.x, simplePointProjection.y, trackProjection);
                    var foulingPointP = engArea.dangerPoints.FirstOrDefault(x => x.trackEdge.Equals(trackEdgesId))?.pos??0;

                    
                    var allocationSection = new AllocationSection()
                    {
                        id = Guid.NewGuid().ToString(),
                        name = $"AS_{item.id}",
                        linearLocation = new LinkedPath() {
                            skipFromPathStart = SkipFromStart(centerLinesCrossingP,foulingPointP,trackProjection),
                            skipFromPathEnd = SkipFromEnd(centerLinesCrossingP, foulingPointP, trackProjection),
                            dirTrackEdges = new List<DirTrackEdge>() { new DirTrackEdge() { trackEdge = trackEdgesId, sameDir = (centerLinesCrossingP == 0) ? true : false } }
                        },
                        allocationSections = new List<AllocationSectionRef>()
                    };

                    TpArea.allocationSections.Add(allocationSection);

                    dependent.Add(allocationSection);   
                });

                var correlated = dependent.Select(x => (x, dependent.Except(new List<AllocationSection>() {x}))); //each section and its dependency.
                correlated.ToList().ForEach(x => x.x.allocationSections.AddRange(x.Item2.Select(x=>new AllocationSectionRef() { Ref=x.id})));
            });
        }
        public void PlanDPSG(Infrastructure infrastructure, TrainProtectionArea TpArea)
        {

            TpArea.dpsGroups = new List<DriveProtectionSectionGroup>();

            var simplePoints = infrastructure?.functionalAreas.SelectMany(x => x.simplePoints);

            simplePoints?.ToList().ForEach(item => {

                var simplePointProjection = infrastructure?.mapAreas.SelectMany(x => x.funcElements).FirstOrDefault(x => {
                    if (x.elementRef?.simplePoint != null)
                    {
                        return x.elementRef.simplePoint.Ref.Equals(item.id);
                    }
                    else { return false; }
                });

                var trackEdgesIds = infrastructure?.topoAreas.SelectMany(x => x.trackEdgeLinks)
                    .Where(x => x.id.Equals(item.mainTrack) || x.id.Equals(item.branchTrack))
                    .Select(x => new[] { x.trackEdgeA, x.trackEdgeB }).SelectMany(x => x)
                    .GroupBy(item => item)
                    .Where(group => group.Count() == 1)
                    .Select(group => group.Key);

                var dpsg = new DriveProtectionSectionGroup()
                {
                    id = Guid.NewGuid().ToString(),
                    name = $"DPSG_{item.id}",
                    driveProtectionSections = new List<DriveProtectionSection>(),
                    dependenciesType = DPSDependencyType.Exclusive, //only for simplePoint.
                    dependencies = new List<uint>(),
                    protectedInfraElements = new ProtectedInfraElement() { simplePoint = new tp.SimplePointRef() { Ref = item.id } }
                };


                trackEdgesIds?.ToList().ForEach(trackEdgesId => {

                    var trackProjection = infrastructure?.mapAreas.SelectMany(x => x.trackEdges).First(x => x.id.Equals(trackEdgesId));

                    if (trackProjection == null || simplePointProjection == null) return;

                    uint tipShift = 1000; //assumed according to the discussions.
                    uint bladeLength = 3000; //assumed till other data come.


                    // track edge start beside the simple point or no.
                    var start = infrastructure?.topoAreas.SelectMany(x => x.trackEdgeLinks)
                        .Where(x => x.id.Equals(item.branchTrack) || x.id.Equals(item.mainTrack))
                        .Where(x => x.trackEdgeA.Equals(trackEdgesId) || x.trackEdgeB.Equals(trackEdgesId))
                        .Select(x =>
                        {
                            if (x.trackEdgeA.Equals(trackEdgesId)) return x.startOfA;
                            return x.startOfB;
                        }).First();

                    uint tipP = GetNearestP(simplePointProjection.x, simplePointProjection.y, trackProjection);

                    uint bladeEndP = 0;

                    if (start==true)
                    {
                        tipP = tipP + tipShift;
                        bladeEndP = tipP + bladeLength;
                    }
                    else
                    {
                        tipP = tipP - tipShift;
                        bladeEndP = tipP - bladeLength;
                    }

                    var dps = new DriveProtectionSection()
                    {
                        id = Guid.NewGuid().ToString(),
                        name = $"DPS_{dpsg.id}",
                        trackEdgeSection = new TrackEdgeSection()
                        {
                            trackEdge = trackProjection.id,
                            skipFromPathStart = SkipFromStart(tipP, bladeEndP, trackProjection),
                            skipFromPathEnd = SkipFromEnd(tipP, bladeEndP, trackProjection),

                        },
                        
                    };

                    dpsg.driveProtectionSections.Add(dps);
                    dpsg.dependencies.Add(0);
                    dpsg.dependencies.Add(1);
                });
                TpArea.dpsGroups.Add(dpsg);
            });
        }
        private uint SkipFromStart(uint p1, uint p2, TrackEdgeProjection trackProjection)
        {
            var startP = trackProjection.coordinates[0].pos;
            var result = (uint)Math.Abs((double)startP - (double)Math.Min(p1, p2));
            return result;
        }
        private uint SkipFromEnd(uint p1, uint p2, TrackEdgeProjection trackProjection)
        {
            var endP = trackProjection.coordinates[trackProjection.coordinates.Count - 1].pos;
            var result = (uint)Math.Abs((double)endP - (double)Math.Max(p1, p2));
            return result;
        }
        /// <summary>
        /// Get nearest P (without interpolation) of a traack edge to a specific x,y value
        /// </summary>
        /// <param name="xValue"></param>
        /// <param name="yValue"></param>
        /// <param name="trackProjection"></param>
        /// <returns></returns>
        private uint GetNearestP(double xValue , double yValue, TrackEdgeProjection trackProjection)
        {
            var NearestOrdered = trackProjection.coordinates.OrderBy(coor => GetDistance(xValue, yValue, coor.x, coor.y));

            return NearestOrdered.First().pos;
        }
        /// <summary>
        /// Move away from P along the trackprojection by distance p 
        /// </summary>
        /// <param name="fromP">location from which moving away happens</param>
        /// <param name="byP">value by which moving away happens</param>
        /// <param name="trackProjection"></param>
        /// <returns></returns>
        private uint MoveAway(uint fromP, uint byP, TrackEdgeProjection trackProjection)
        {
            var p_after = trackProjection.coordinates.FirstOrDefault(x => x.pos >= fromP)?.pos;
            var p_before = trackProjection.coordinates.FirstOrDefault(x => x.pos <= fromP)?.pos;

            if(p_after!=null)
            {
                var difference = (double)fromP - (double)p_after;
                if (difference > 0)
                {
                    return fromP - byP;
                }
                else
                {
                    return fromP + byP;
                }
            }

            if (p_before != null)
            {
                var difference = (double)fromP - (double)p_before;
                if (difference < 0)
                {
                    return fromP - byP;
                }
                else
                {
                    return fromP + byP;
                }
            }
            return fromP;
        }
        /// <summary>
        /// Eucledian Distance between two points of x,y
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        private double GetDistance(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            return distance;
        }
       
    }
}
