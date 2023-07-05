using System.Xml.Serialization;
using System.Collections.Generic;
using infra;

namespace infra
{
    public class DirTrackEdgePoint
    {
        public TrackEdgePoint trackEdgePoint;
        [XmlAttribute]
        public Direction direction;
    }
}
