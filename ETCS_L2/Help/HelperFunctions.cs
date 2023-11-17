using eng;
using Geometry;
using infra;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CCSTMS.ETCS_L2_Planning
{
    public class HelperFunctions
    {
        public static Point GetCoordinatesFromP(TrackEdgeProjection trackEdgeProjection, uint p)
        {
            var coordianteAfter = trackEdgeProjection.coordinates.Where(x => x.pos >= p).Select(x => x).FirstOrDefault();
            var coordianteBefore = trackEdgeProjection.coordinates.Where(x => x.pos <= p).Select(x => x).LastOrDefault();

            var pRatio = coordianteAfter != null && coordianteBefore != null && coordianteAfter.pos - coordianteBefore.pos != 0 ? (p - (double)coordianteBefore.pos) / (coordianteAfter.pos - (double)coordianteBefore.pos) : 0;

            coordianteAfter ??= trackEdgeProjection.coordinates[trackEdgeProjection.coordinates.Count - 1];
            if (coordianteBefore == null) coordianteAfter = trackEdgeProjection.coordinates[0];

            var xdiff = coordianteAfter.x - coordianteBefore.x;
            var ydiff = coordianteAfter.y - coordianteBefore.y;

            var x = coordianteBefore.x + xdiff * pRatio;
            var y = coordianteBefore.y + ydiff * pRatio;

            return new(x, y,0);

        }
        public static double GetSpeedOnTrackatP(Infrastructure infra, TrackEdgeProjection trackEdgeProjection, uint p)
        {
            var speeds = infra.functionalAreas[0].teSpeedProfiles
                .Where(x => x.id.Equals(trackEdgeProjection.id))
                .SelectMany(x => x.staticSpeedProfile)
                .Where(x => x.pos <= p)
                .Select(x => x.speed).LastOrDefault();

            return speeds;
        }
        public static double CalculateDistance(Point point1, Point point2)
        {
            double dx = point2.X - point1.X;
            double dy = point2.Y - point1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public static bool DecideWithDirectionToMove(TrackEdgeProjection projection, uint bufferP)
        {
            var distanceA = Math.Abs(projection.coordinates[0].pos - (double)bufferP);
            var distanceB = Math.Abs(projection.coordinates[projection.coordinates.Count - 1].pos - (double)bufferP);
            if (distanceA <= distanceB) return true; // move with P increment. assuming P is sorted.
            return false; //move the opposite direction
        }
        public static TrackEdgePoint MoveVehicleOverhungDistance(int trackEdgeCoordianteIndex, TrackEdgeProjection trackEdgeProjection, DangerPoint dangePointProjection = null, uint vehicleOverhungDistance = 5000)
        {
            if (dangePointProjection == null)
            {
                return MoveOverhungDistanceFromP(trackEdgeProjection.coordinates[trackEdgeCoordianteIndex].pos, trackEdgeProjection, trackEdgeCoordianteIndex, vehicleOverhungDistance);
            }
            else
            {
                return MoveOverhungDistanceFromP(dangePointProjection.pos, trackEdgeProjection, trackEdgeCoordianteIndex, vehicleOverhungDistance);
            }
        }
        private static TrackEdgePoint MoveOverhungDistanceFromP(uint p, TrackEdgeProjection trackEdgeProjection, int trackEdgeCoordianteIndex, uint vehicleOverhungDistance = 5000)
        {
            // simple point is at the end of the track coordiantes
            if (trackEdgeProjection.coordinates.Count - 1 == trackEdgeCoordianteIndex)
            {
                if (p - (double)vehicleOverhungDistance < trackEdgeProjection.coordinates[0].pos)
                {
                    return new() { trackEdge = trackEdgeProjection.id, pos = trackEdgeProjection.coordinates[trackEdgeProjection.coordinates.Count - 1].pos / 2 };
                }
                return new() { trackEdge = trackEdgeProjection.id, pos = p - vehicleOverhungDistance };
            }// simple point is at the beginning of the track coordiantes
            else if (trackEdgeCoordianteIndex == 0)
            {
                if (p + vehicleOverhungDistance > trackEdgeProjection.coordinates[trackEdgeProjection.coordinates.Count - 1].pos)
                {
                    return new() { trackEdge = trackEdgeProjection.id, pos = trackEdgeProjection.coordinates[trackEdgeProjection.coordinates.Count - 1].pos / 2 };
                }
                return new() { trackEdge = trackEdgeProjection.id, pos = p + vehicleOverhungDistance };
            }
            return null;
        }
        public static Point CoordinatesFromP(TrackEdge trackEdge, uint p, Infrastructure infra, int mapAreaIndex)
        {
            var trackEdgeProjection = infra.mapAreas[mapAreaIndex].trackEdges.Find(x => x.id.Equals(trackEdge.id));

            var coordianteAfter = trackEdgeProjection?.coordinates.Where(x => x.pos >= p).Select(x => x).FirstOrDefault();
            var coordianteBefore = trackEdgeProjection?.coordinates.Where(x => x.pos <= p).Select(x => x).LastOrDefault();

            var pRatio = coordianteAfter != null && coordianteBefore != null && coordianteAfter.pos - coordianteBefore.pos != 0 ? (p - (double)coordianteBefore.pos) / (coordianteAfter.pos - (double)coordianteBefore.pos) : 0;

            coordianteAfter ??= trackEdgeProjection.coordinates[trackEdgeProjection.coordinates.Count - 1];
            if (coordianteBefore == null) coordianteAfter = trackEdgeProjection.coordinates[0];

            var xdiff = coordianteAfter.x - coordianteBefore.x;
            var ydiff = coordianteAfter.y - coordianteBefore.y;

            var x = coordianteBefore.x + xdiff * pRatio;
            var y = coordianteBefore.y + ydiff * pRatio;

            return new(x, y,0);

        }
        public static TrackEdgePoint MoveDistance(bool startToEnd, TrackEdge trackEdge, DangerPoint dangePointProjection = null, uint distance = 5000)
        {

            if (dangePointProjection == null && startToEnd)
            {
                return MoveDistanceFromP(0, trackEdge, startToEnd, distance);
            }
            if (dangePointProjection == null && !startToEnd)
            {
                return MoveDistanceFromP(trackEdge.length, trackEdge, startToEnd, distance);
            }
            else
            {
                return MoveDistanceFromP(dangePointProjection.pos, trackEdge, startToEnd, distance);

            }
        }
        public static TrackEdgePoint MoveDistanceFromP(uint p, TrackEdge trackEdge, bool startToEnd, uint distance)
        {
            // simple point is at the end of the track coordiantes
            if (startToEnd)
            {
                if ((double)p + (double)distance >= trackEdge.length)
                {
                    return new() { trackEdge = trackEdge.id, pos = trackEdge.length / 2 };
                }
                return new() { trackEdge = trackEdge.id, pos = p + distance };
            }// simple point is at the beginning of the track coordiantes
            else if (!startToEnd)
            {
                if ((double)p - (double)distance <= 0)
                {
                    return new() { trackEdge = trackEdge.id, pos = trackEdge.length / 2 };
                }
                return new() { trackEdge = trackEdge.id, pos = p - distance };
            }
            return null;
        }
        public static uint SectionLength(TrackEdgeSection section, Infrastructure infra, int topoAreaIndex)
        {
            if (section.skipFromPathStart == 0) return section.skipFromPathEnd;
            if (section.skipFromPathEnd == 0) return infra.topoAreas[topoAreaIndex].trackEdges.Find(x => x.id.Equals(section.trackEdge)).length - section.skipFromPathStart;
            if (section.skipFromPathEnd != 0 && section.skipFromPathStart != 0) return infra.topoAreas[topoAreaIndex].trackEdges.Find(x => x.id.Equals(section.trackEdge)).length - section.skipFromPathEnd - section.skipFromPathStart;
            return 0;
        }
    }
    public class SD1_Path
    {
        public static List<SD1_Path> paths = new();
        public static List<TrackEdgeLink> visitedLinks = new();
        public List<string> path;
        public SD1_Path()
        {
            path = new();
            visitedLinks = new();
        }
    }
    public class MyObjectEqualityComparer : IEqualityComparer<List<object>>
    {
        public bool Equals(List<object> x, List<object> y)
        {
            if (ReferenceEquals(x, y))
                return true;

            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
                return false;

            return x[2].Equals(y[2]);
        }
        public int GetHashCode(List<object> obj)
        {
            return obj[2].GetHashCode();
        }
    }
}
