using eng;
using Geometry;
using infra;
using System;
using System.Linq;


namespace CCSTMS.ETCS_L2_Planning
{
    /// <summary>
    /// A Class to plan a ETCSmarkers according to Generic engineering rules document dated 6-15-2023
    /// </summary>
    public class ETCSmarker
    {
        public void Plan(Infrastructure infra, EngArea engArea)
        {
            infra.functionalAreas[0].etcsMarkers = new();
            //place with TVPS
            ETCSmarker_TVPS(infra, infra.functionalAreas[0]);
            ETCSmarker_BufferStop(infra);
        }

        #region ETCSmarker_BufferStop
        /// <summary>
        /// Place ETCSmarker boards at bufferStops
        /// </summary>
        /// <param name="infra"></param>
        private void ETCSmarker_BufferStop(Infrastructure infra)
        {
            var bufferStop = infra.functionalAreas[0].bufferStops;

            foreach (var item in bufferStop)
            {
                var avalaibleMarker = infra.functionalAreas.SelectMany(x => x.etcsMarkers).Where(x => x.pos == item.pos && x.trackEdge.Equals(item.trackEdge)).FirstOrDefault();

                if (avalaibleMarker != null) return;

                var trackEdgeProjection = infra.mapAreas[0].trackEdges.Find(x => x.id.Equals(item.trackEdge));

                ETCSMarker marker = new() { id = Guid.NewGuid().ToString(), trackEdge = trackEdgeProjection.id };

                var coordinate = HelperFunctions.GetCoordinatesFromP(trackEdgeProjection, marker.pos);
                ProjectETCSmarker(coordinate, marker, infra);

                infra.functionalAreas[0].etcsMarkers.Add(marker);           
            }
        }

        /// <summary>
        /// Decide which direction to move according to the location of the buffer stop.
        /// </summary>
        /// <param name="projection"></param>
        /// <param name="bufferP"></param>
        /// <returns></returns>
        private bool DecideWithDirectionToMove(TrackEdgeProjection projection, uint bufferP)
        {
            var distanceA = Math.Abs(projection.coordinates[0].pos - (double)bufferP);
            var distanceB = Math.Abs(projection.coordinates[projection.coordinates.Count - 1].pos - (double)bufferP);
            if (distanceA <= distanceB) return true; // move with P increment. assuming P is sorted.
            return false; //move the opposite direction
        }
        #endregion

        #region ETCSmarker_TVPS
        /// <summary>
        /// Place ETCSmarker for TVPS
        /// </summary>
        /// <param name="infra"></param>
        /// <param name="funcArea"></param>
        private void ETCSmarker_TVPS(Infrastructure infra, FunctionalArea funcArea)
        {
            foreach (var trainDetector in funcArea.trainDetectors)
            {
                ETCSMarker marker = new() { id = Guid.NewGuid().ToString(), trackEdge = trainDetector.trackEdge, pos = trainDetector.pos };
                funcArea.etcsMarkers.Add(marker);

                var trackEdge = infra.mapAreas.SelectMany(x=>x.trackEdges).Single(x => x.id.Equals(marker.trackEdge));

                var coordinate = HelperFunctions.GetCoordinatesFromP(trackEdge, marker.pos);
                ProjectETCSmarker(coordinate, marker, infra);
            }
        }
        #endregion

        #region Misc
        /// <summary>
        /// Project a ETCSmarker to x,y,z values based on their placement on track.
        /// </summary>
        /// <param name="coordinate"></param>
        /// <param name="BG"></param>
        /// <param name="infra"></param>
        private void ProjectETCSmarker(Point coordinate, ETCSMarker marker, Infrastructure infra)
        {
            FuncElementProjection projection = new FuncElementProjection() { elementRef = new FuncElementRef() { etcsMarker = new EtcsMarkerRef() {Ref = marker.id } }, x = coordinate.X, y = coordinate.Y };
            infra.mapAreas[0].funcElements.Add(projection);

        }

        private ETCSMarker CheckPlacedETCSmarker(FunctionalArea funcArea, string trackEdgeID, uint p)
        {
            var avalaibleMarker = funcArea.etcsMarkers.Where(x => x.trackEdge.Equals(trackEdgeID) && ((double)x.pos > (double)p - 100 && (double)x.pos < (double)p + 100)).Select(x=>x);
            return avalaibleMarker.Count() > 0 ? avalaibleMarker.ToArray()[0] : null;
        }
        #endregion
    }
}
