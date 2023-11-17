using infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSTMS.ETCS_L2_Planning
{
    public class Help
    {
        #region general
        public static uint SkipFromStart(uint p1, uint p2)
        {
            var startP = 0;
            var result = (uint)Math.Abs((double)startP - (double)Math.Min(p1, p2));
            return result;
        }
        public static uint SkipFromEnd(uint p1, uint p2, TrackEdge trackEdge)
        {
            var endP = trackEdge.length;
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
        public static uint GetNearestP(double xValue, double yValue, TrackEdgeProjection trackProjection)
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
        public static uint MoveAway(uint fromP, uint byP, TrackEdgeProjection trackProjection)
        {
            var p_after = trackProjection.coordinates.FirstOrDefault(x => x.pos >= fromP)?.pos;
            var p_before = trackProjection.coordinates.FirstOrDefault(x => x.pos <= fromP)?.pos;

            if (p_after != null)
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
        public static double GetDistance(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            return distance;
        }
        #endregion


        #region simplePoint
        public static List<TrackEdge> SimplePointTrackEdges(Infrastructure infra, SimplePoint simplePoint)
        {
            var trackEdgesIDs = infra.topoAreas.SelectMany(x => x.trackEdgeLinks)
              .Where(x => x.id.Equals(simplePoint.branchTrack)  || x.id.Equals(simplePoint.mainTrack))
              .SelectMany(x => new[] {x.trackEdgeA,x.trackEdgeB}).Distinct();

            var trackEdges = infra.topoAreas.SelectMany(x => x.trackEdges).Where(x => trackEdgesIDs.Contains(x.id)).ToList();

            return trackEdges;
        }
        #endregion
    }
}
