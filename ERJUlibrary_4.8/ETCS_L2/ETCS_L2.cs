using eng;
using infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using SimplePoint = infra.SimplePoint;
using TrackEdgeSection = infra.TrackEdgeSection;

namespace APLan.Model.SD1
{
    public class ETCS_L2
    {
        public void PlanETCS_L2(Infrastructure infra, EngArea engArea)
        {
            PlanTVPS(infra, engArea);
            PlanETCSmarkerBoards(infra, infra.functionalAreas[0]);
            PlanBaliseGroup(infra, infra.functionalAreas[0],engArea);
        }
        
        #region TVPS
        private void PlanTVPS(Infrastructure infra, EngArea engArea)
        {
            if (infra == null || engArea == null) return;

            PlanTVPSaroundSimplePoints(infra, engArea);
            PlanTVPSatEmptySpaces(infra, infra.functionalAreas[0]);
        }
        /// <summary>
        /// Design TVPS around simple point.
        /// </summary>
        /// <param name="infra"></param>
        /// <param name="engArea"></param>
        private void PlanTVPSaroundSimplePoints(Infrastructure infra,EngArea engArea)
        {
           
            var simplePoints = infra.functionalAreas[0].simplePoints;
            infra.functionalAreas[0].trainDetectors = new();
            foreach (var item in simplePoints)
            {
                //get necessary data for processing.
                var linksIds = item.trackEdgeLinks.Select(x => x.Ref);
                var links = infra.topoAreas[0].trackEdgeLinks.Where(x => linksIds.Contains(x.Id)).Select(x => x);
                var linksEdgesIds = links.Select(x => x.TrackEdgeA).Concat(links.Select(x => x.TrackEdgeB));
                var trackEdgesIds = infra.topoAreas[0].trackEdges.Where(x => linksEdgesIds.Contains(x.Id)).Select(x => x.Id);
                var trackEdgeProjections = infra.mapAreas[0].trackEdges.Where(x => trackEdgesIds.Contains(x.TrackEdgeId)).Select(x => x);

                //place axle counters around tvps
                var trainDetectorsAndEdgeSections = PlaceAxleCounterAroundSimplePoint(item, trackEdgeProjections, infra, engArea);
                var trainDetectorsRefs = trainDetectorsAndEdgeSections.Select(x => new TrainDetectorRef() { Ref = ((TrainDetector)x[0]).Id }).ToList();

                //add axle counter
                infra.functionalAreas[0].trainDetectors.AddRange(trainDetectorsAndEdgeSections.Select(x => (TrainDetector)x[0]));

                //create tvps
                var tvps = new TvpSection() { Id = Guid.NewGuid().ToString(), trainDetectors = new(), trackSections = new() };
                tvps.trainDetectors.AddRange(trainDetectorsRefs);
                tvps.trackSections.AddRange(trainDetectorsAndEdgeSections.Select(x => (TrackEdgeSection)x[1]));
                infra.functionalAreas[0].tvps.Add(tvps);
            }
        }
        /// <summary>
        /// Design TVPS for spaces not around simple points.
        /// </summary>
        /// <param name="infra"></param>
        /// <param name="funcArea"></param>
        private static void PlanTVPSatEmptySpaces(Infrastructure infra, FunctionalArea funcArea)
        {
            foreach (var item in infra.mapAreas[0].trackEdges)
            {
                var trackSections = funcArea.tvps.Where(x => x.trackSections.Select(y => y.TrackEdge).Contains(item.TrackEdgeId))
                    .Select(x => x.trackSections)
                    .SelectMany(x => x)
                    .Where(x => x.TrackEdge.Equals(item.TrackEdgeId))
                    .Select(x => x);

                PlanTVPSforEmptySpace(trackSections, item, infra);
            }
        }
        /// <summary>
        /// Design a TVPS for a space that don't have.
        /// </summary>
        /// <param name="trackEdgeSections"></param>
        /// <param name="trackEdgeProjection"></param>
        /// <param name="infra"></param>
        private static void PlanTVPSforEmptySpace(IEnumerable<TrackEdgeSection> trackEdgeSections, TrackEdgeProjection trackEdgeProjection, Infrastructure infra)
        {
            var emptyZones = GetEmptyZones(trackEdgeSections, trackEdgeProjection);
            PlanTVPSforEmptySpaceZones(emptyZones, trackEdgeProjection, infra);
        }
        /// <summary>
        /// Design TVPS for zones of an empty space
        /// </summary>
        /// <param name="emptyZones"></param>
        /// <param name="trackEdgeProjection"></param>
        /// <param name="infra"></param>
        private static void PlanTVPSforEmptySpaceZones(List<List<uint>> emptyZones, TrackEdgeProjection trackEdgeProjection, Infrastructure infra)
        {
            foreach (var zone in emptyZones)
            {
                var limitiedZones = SubdivideIntoZones(zone, 500000, 21000);
                limitiedZones.ForEach(x => PlanTVPSforZone(x, trackEdgeProjection,infra));
            }
        } 
        /// <summary>
        /// Plan TVPS for an empty zone
        /// </summary>
        /// <param name="zone"></param>
        /// <param name="trackEdgeProjection"></param>
        /// <param name="infra"></param>
        private static void PlanTVPSforZone(List<uint> zone, TrackEdgeProjection trackEdgeProjection, Infrastructure infra)
        {
            var tvps = new TvpSection() { Id = Guid.NewGuid().ToString(), trainDetectors = new(), trackSections = new() };
            var currentDetectorsOnTrackEdge = infra.functionalAreas[0].trainDetectors.Where(x => x.trackEdgePoint.TrackEdge.Equals(trackEdgeProjection.TrackEdgeId)).Select(x => x);

            foreach (var currentP in zone)
            {
                var detector = currentDetectorsOnTrackEdge.Where(x => currentP + 1000 > x.trackEdgePoint.p && x.trackEdgePoint.p > currentP - 1000).Select(x => x).FirstOrDefault();
                if (detector != null)
                {

                    tvps.trainDetectors.Add(new TrainDetectorRef() { Ref = detector.Id });

                }
                else
                {
                    var trainDetector = new TrainDetector() { Id = Guid.NewGuid().ToString(), type = TrainDetectorType.axleCounter, trackEdgePoint = new() { p = currentP, TrackEdge = trackEdgeProjection.TrackEdgeId } };
                    infra.functionalAreas[0].trainDetectors.Add(trainDetector);
                    var coordinate = GetCoordinatesFromP(trackEdgeProjection, trainDetector.trackEdgePoint.p);
                    ProjectAxleCounter(coordinate, trainDetector, infra);
                    tvps.trainDetectors.Add(new TrainDetectorRef() { Ref = trainDetector.Id });
                };
            }
            tvps.trackSections.Add(new() { skipFromStart = zone[0], skipFromEnd = zone[1], TrackEdge = trackEdgeProjection.TrackEdgeId });
            infra.functionalAreas[0].tvps.Add(tvps);
        }
        /// <summary>
        /// Project an axle counter to produce x,y and z
        /// </summary>
        /// <param name="coordinate"></param>
        /// <param name="trainDetector"></param>
        /// <param name="infra"></param>
        private static void ProjectAxleCounter(Point coordinate, infra.TrainDetector trainDetector, Infrastructure infra)
        {
            FuncElementProjection projection = new() { elementRef = new() { TrainDetector = trainDetector.Id }, x = coordinate.X, y = coordinate.Y };
            infra.mapAreas[0].funcElements.Add(projection);
        }
        /// <summary>
        /// subdivide space into zones according to maximum and minimum limit.
        /// </summary>
        /// <param name="zone"></param>
        /// <param name="maxLimit"></param>
        /// <param name="minLimit"></param>
        /// <returns></returns>
        private static List<List<uint>> SubdivideIntoZones(List<uint> zone, uint maxLimit = 500000, uint minLimit = 0)
        {
            int numberOfZones = (int)Math.Ceiling((double)(zone[1] - zone[0]) / maxLimit);
            // Create a list to store the subdivided zones
            List<List<uint>> zones = new();

            // Subdivide the zones
            uint startValue = zone[0];
            for (int i = 0; i < numberOfZones; i++)
            {
                uint endValue = startValue + maxLimit;
                if (endValue > zone[1])
                    endValue = zone[1];

                if (i > 0 && endValue - startValue < minLimit)
                {
                    // Combine with the previous zone
                    int previousIndex = zones.Count - 1;
                    var size = (endValue - startValue + (zones[previousIndex][1] - zones[previousIndex][0])) / 2;
                    zones[previousIndex][1] = zones[previousIndex][0] + size;

                    endValue = startValue + size;
                }
                else
                {
                    zones.Add(new List<uint>() { startValue, endValue });
                }

                startValue = endValue + 1;
            }
            return zones;
        }
        private static List<List<uint>> GetEmptyZones(IEnumerable<TrackEdgeSection> trackEdgeSections, TrackEdgeProjection trackEdgeProjection)
        {
            List<List<uint>> occupiedZones = new();
            foreach (var item in trackEdgeSections)
            {
                if (item.skipFromStart != 0 && item.skipFromEnd == 0) { occupiedZones.Add(new() { item.skipFromStart, trackEdgeProjection.coordinates[trackEdgeProjection.coordinates.Count-1].p }); }
                else if (item.skipFromEnd != 0 && item.skipFromStart == 0) { occupiedZones.Add(new() { 0, trackEdgeProjection.coordinates[trackEdgeProjection.coordinates.Count - 1].p - item.skipFromEnd }); }
                else if (item.skipFromEnd != 0 && item.skipFromStart != 0) { occupiedZones.Add(new() { item.skipFromStart, trackEdgeProjection.coordinates[trackEdgeProjection.coordinates.Count - 1].p - item.skipFromEnd }); }
            }
            occupiedZones.ForEach(x => x.Sort());
            occupiedZones.Sort((l1, l2) => l1[0].CompareTo(l2[0]));
            return EmptyZones(trackEdgeProjection, occupiedZones);
        }
        private static List<List<uint>> EmptyZones(TrackEdgeProjection trackEdgeProjection, List<List<uint>> occupiedZones)
        {
            var emptyZones = new List<List<uint>>();
            var maxP = trackEdgeProjection.coordinates[trackEdgeProjection.coordinates.Count - 1].p;

            for (int i = 0; i < occupiedZones.Count - 1; i++)
            {
                var zone = new List<uint>() { occupiedZones[i][1], occupiedZones[i + 1][0] };
                emptyZones.Add(zone);
            }
            if (occupiedZones.Count == 1 && occupiedZones[0][0] != 0) { emptyZones.Add(new() { 0, occupiedZones[0][0] }); }
            if (occupiedZones.Count == 1 && occupiedZones[0][0] == 0) { emptyZones.Add(new() { occupiedZones[0][1], maxP }); }
            return emptyZones;
        }
        private IEnumerable<object[]> PlaceAxleCounterAroundSimplePoint(SimplePoint simplePoint, IEnumerable<TrackEdgeProjection> trackEdgeProjections, Infrastructure infra,EngArea engArea)
        {
            List<object[]> data = new();
            var sPointCoordinate = infra.mapAreas[0].funcElements.Where(x => x.elementRef.SimplePoint.Equals(simplePoint.Id)).First();
            foreach (var item in trackEdgeProjections)
            {
                
                var nearestCoordianteIndex = CalculateDistance(new Point(sPointCoordinate.x, sPointCoordinate.y), new Point(item.coordinates[0].x, item.coordinates[0].y))
                    < CalculateDistance(new Point(sPointCoordinate.x, sPointCoordinate.y), new Point(item.coordinates[item.coordinates.Count - 1].x, item.coordinates[item.coordinates.Count - 1].y)) ? 0 : item.coordinates.Count - 1;

                var engSimplePointDangerPoints = engArea.simplePoints.Find(x => x.Id.Equals(simplePoint.Id))?.dangerPoints.Select(x => x.Ref);

                var dangerPoints = engArea.dangerPoints.Where(x => x.trackEdgePoint.TrackEdge.Equals(item.TrackEdgeId))?.Select(x => x.Id);

                var dangerPointOfPointOnTrackEdge = engSimplePointDangerPoints != null && dangerPoints != null ? engSimplePointDangerPoints.Intersect(dangerPoints).FirstOrDefault() : null;

                var dangerPoint = engArea.dangerPoints.Find(x => x.Id.Equals(dangerPointOfPointOnTrackEdge));

                var TrackDetectorPoint = dangerPoint == null ? MoveVehicleOverhungDistance(nearestCoordianteIndex, item) : MoveVehicleOverhungDistance(nearestCoordianteIndex, item, dangerPoint);

                var trainDetector = new TrainDetector
                {
                    Id = Guid.NewGuid().ToString(),
                    type = TrainDetectorType.axleCounter,
                    trackEdgePoint = new() { TrackEdge = item.TrackEdgeId, p = TrackDetectorPoint.p }
                };

                var coordinate = GetCoordinatesFromP(item, trainDetector.trackEdgePoint.p);
                ProjectAxleCounter(coordinate, trainDetector, infra);

                var trackEdgeSection = new TrackEdgeSection() { TrackEdge = item.TrackEdgeId };

                if (nearestCoordianteIndex == 0) { trackEdgeSection.skipFromEnd = item.coordinates[item.coordinates.Count - 1].p - TrackDetectorPoint.p; }
                if (nearestCoordianteIndex != 0) { trackEdgeSection.skipFromStart = TrackDetectorPoint.p; }

                data.Add(new object[] { trainDetector, trackEdgeSection });
            }
            return data;
        }

        /// <summary>
        /// Move far away from the simple point by overhung distance from simple point or associated danger point.
        /// </summary>
        /// <param name="trackEdgeCoordianteIndex">nearest coordinate index to the simple point</param>
        /// <param name="trackEdgeProjection">projection of the trackedge to points</param>
        /// <param name="simplePointProjection">projection of the simple point</param>
        /// <param name="dangePointProjection">projection of the danger point</param>
        /// <param name="vehicleOverhungDistance">selected overhung distance</param>
        /// <returns></returns>
        private TrackEdgePoint MoveVehicleOverhungDistance(int trackEdgeCoordianteIndex, TrackEdgeProjection trackEdgeProjection, DangerPoint dangePointProjection = null, uint vehicleOverhungDistance = 5000)
        {
            if (dangePointProjection == null)
            {
                return MoveOverhungDistanceFromP(trackEdgeProjection.coordinates[trackEdgeCoordianteIndex].p, trackEdgeProjection, trackEdgeCoordianteIndex, vehicleOverhungDistance); 
            }
            else
            {
                return MoveOverhungDistanceFromP(dangePointProjection.trackEdgePoint.p, trackEdgeProjection, trackEdgeCoordianteIndex, vehicleOverhungDistance);
            }
        }

        /// <summary>
        /// Move Overhung distance from P according to nearest point to simple point index.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="trackEdgeProjection"></param>
        /// <param name="trackEdgeCoordianteIndex"></param>
        /// <param name="vehicleOverhungDistance"></param>
        /// <returns></returns>
        private TrackEdgePoint MoveOverhungDistanceFromP(uint p,TrackEdgeProjection trackEdgeProjection,int trackEdgeCoordianteIndex,uint vehicleOverhungDistance = 5000)
        {
            // simple point is at the end of the track coordiantes
            if (trackEdgeProjection.coordinates.Count - 1 == trackEdgeCoordianteIndex)
            {
                if (p - (double)vehicleOverhungDistance < trackEdgeProjection.coordinates[0].p)
                {
                    return new() { TrackEdge = trackEdgeProjection.TrackEdgeId, p = trackEdgeProjection.coordinates[trackEdgeProjection.coordinates.Count - 1].p / 2 };
                }
                return new() { TrackEdge = trackEdgeProjection.TrackEdgeId, p = p - vehicleOverhungDistance };
            }// simple point is at the beginning of the track coordiantes
            else if (trackEdgeCoordianteIndex == 0)
            {
                if (p + vehicleOverhungDistance > trackEdgeProjection.coordinates[trackEdgeProjection.coordinates.Count - 1].p)
                {
                    return new() { TrackEdge = trackEdgeProjection.TrackEdgeId, p = trackEdgeProjection.coordinates[trackEdgeProjection.coordinates.Count - 1].p / 2 };
                }
                return new() { TrackEdge = trackEdgeProjection.TrackEdgeId, p = p + vehicleOverhungDistance };
            }
            return null;
        }
        #endregion
        #region ETCSmarkers
        private static void PlanETCSmarkerBoards(Infrastructure infra, FunctionalArea funcArea)
        {
            funcArea.etcsMarkers = new();
            //place with TVPS
            PlanETCSmarkerBoardsAtTVPS(infra, funcArea);

        }
        private static void PlanETCSmarkerBoardsAtTVPS(Infrastructure infra, FunctionalArea funcArea)
        {
            foreach (var item in funcArea.tvps)
            {
                var detectorsRefs = item.trainDetectors.Select(y => y.Ref).ToList();
                var edgePoints = infra.functionalAreas[0].trainDetectors.Where(x => detectorsRefs.Contains(x.Id)).Select(x => x.trackEdgePoint);
                foreach (var point in edgePoints)
                {
                    if (funcArea.etcsMarkers.Where(x => x.dirTrackEdgePoint.trackEdgePoint.p == point.p && x.dirTrackEdgePoint.trackEdgePoint.TrackEdge.Equals(point.TrackEdge)).Select(x => x).FirstOrDefault() == null)
                    {
                        ETCSMarker marker = new() { Id = Guid.NewGuid().ToString(), dirTrackEdgePoint = new() { trackEdgePoint = new() { TrackEdge = point.TrackEdge, p = point.p } } };
                        funcArea.etcsMarkers.Add(marker);

                        var trackEdge = infra.mapAreas[0].trackEdges.Find(x => x.TrackEdgeId.Equals(marker.dirTrackEdgePoint.trackEdgePoint.TrackEdge));
                        var coordinate = GetCoordinatesFromP(trackEdge, marker.dirTrackEdgePoint.trackEdgePoint.p);
                        ProjectETCSmarker(coordinate, marker,infra);
                    }
                }
            }
        }
        private static void ProjectETCSmarker(Point coordinate, ETCSMarker marker,Infrastructure infra)
        {
            FuncElementProjection projection = new() { elementRef = new() { EtcsMarker = marker.Id }, x = coordinate.X, y = coordinate.Y };
            infra.mapAreas[0].funcElements.Add(projection);

        }
        private static Point GetCoordinatesFromP(TrackEdgeProjection trackEdgeProjection, uint p)
        {
            var coordianteAfter = trackEdgeProjection.coordinates.Where(x => x.p >= p).Select(x => x).FirstOrDefault();
            var coordianteBefore = trackEdgeProjection.coordinates.Where(x => x.p <= p).Select(x => x).LastOrDefault();

            var pRatio = coordianteAfter != null && coordianteBefore != null && coordianteAfter.p - coordianteBefore.p != 0 ? (p - (double)coordianteBefore.p) / (coordianteAfter.p - (double)coordianteBefore.p) : 0;

            coordianteAfter ??= trackEdgeProjection.coordinates[trackEdgeProjection.coordinates.Count - 1];
            if (coordianteBefore == null) coordianteAfter = trackEdgeProjection.coordinates[0];

            var xdiff = coordianteAfter.x - coordianteBefore.x;
            var ydiff = coordianteAfter.y - coordianteBefore.y;

            var x = coordianteBefore.x + xdiff * pRatio;
            var y = coordianteBefore.y + ydiff * pRatio;

            return new(x, y);

        }
        #endregion
        #region BaliseGroup
        public void PlanBaliseGroup(Infrastructure infra, FunctionalArea funcArea,EngArea engArea)
        {
            funcArea.baliseGroups = new();

            PlanBaliseGroupsInfrontOfDangerPoint(infra, funcArea, engArea);
        }
        private void PlanBaliseGroupsInfrontOfDangerPoint(Infrastructure infra, FunctionalArea funcArea, EngArea engArea)
        {
            var simplePoints = funcArea.simplePoints;
            foreach (var item in simplePoints)
            {
                var linksIds = item.trackEdgeLinks.Select(x => x.Ref);
                var links = infra.topoAreas[0].trackEdgeLinks.Where(x => linksIds.Contains(x.Id)).Select(x => x);
                var linksEdgesIds = links.Select(x => x.TrackEdgeA).Concat(links.Select(x => x.TrackEdgeB));
                var trackEdgesIds = infra.topoAreas[0].trackEdges.Where(x => linksEdgesIds.Contains(x.Id)).Select(x => x.Id);
                var trackEdgeProjections = infra.mapAreas[0].trackEdges.Where(x => trackEdgesIds.Contains(x.TrackEdgeId)).Select(x => x);

                PlaceBaliseBeforeDangerPoint(item, trackEdgeProjections, infra, engArea);
            }
        }
        private void PlaceBaliseBeforeDangerPoint(SimplePoint simplePoint, IEnumerable<TrackEdgeProjection> trackEdgeProjections, Infrastructure infra, EngArea engArea)
        {
            var sPointCoordinate = infra.mapAreas[0].funcElements.Where(x => x.elementRef.SimplePoint.Equals(simplePoint.Id)).First();
            foreach (var item in trackEdgeProjections)
            {
                var baliseGroup = new BaliseGroup() { Id = Guid.NewGuid().ToString(), balises = new() };

                var nearestCoordianteIndex = CalculateDistance(new Point(sPointCoordinate.x, sPointCoordinate.y), new Point(item.coordinates[0].x, item.coordinates[0].y))
                    < CalculateDistance(new Point(sPointCoordinate.x, sPointCoordinate.y), new Point(item.coordinates[item.coordinates.Count - 1].x, item.coordinates[item.coordinates.Count - 1].y)) ? 0 : item.coordinates.Count - 1;

                var engSimplePointDangerPoints = engArea.simplePoints.Find(x => x.Id.Equals(simplePoint.Id))?.dangerPoints.Select(x => x.Ref);

                var dangerPoints = engArea.dangerPoints.Where(x => x.trackEdgePoint.TrackEdge.Equals(item.TrackEdgeId))?.Select(x => x.Id);

                var dangerPointOfPointOnTrackEdge = engSimplePointDangerPoints != null && dangerPoints != null ? engSimplePointDangerPoints.Intersect(dangerPoints).FirstOrDefault() : null;

                var dangerPoint = engArea.dangerPoints.Find(x => x.Id.Equals(dangerPointOfPointOnTrackEdge));

                if (dangerPoint != null)
                {
                    var TrackEdgepoint = MoveVehicleOverhungDistance(nearestCoordianteIndex, item, dangerPoint, 18000);
                    baliseGroup.balises.Add(new() { Id = Guid.NewGuid().ToString(), trackEdgePoint = new() { TrackEdge = item.TrackEdgeId, p = TrackEdgepoint.p } });
                    var coordinate = GetCoordinatesFromP(item, TrackEdgepoint.p);
                    ProjectBaliseGroup(coordinate, baliseGroup, infra);
                    infra.functionalAreas[0].baliseGroups.Add(baliseGroup);
                }
            }
        }
        private static void ProjectBaliseGroup(Point coordinate, infra.BaliseGroup BG,Infrastructure infra)
        {
            FuncElementProjection projection = new() { elementRef = new() { Balise = BG.Id }, x = coordinate.X, y = coordinate.Y };
            infra.mapAreas[0].funcElements.Add(projection);
        }
        #endregion
        #region Geometry
        /// <summary>
        /// Get linear distance between two points
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        private static double CalculateDistance(Point point1, Point point2)
        {
            double dx = point2.X - point1.X;
            double dy = point2.Y - point1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        #endregion
    }
}
