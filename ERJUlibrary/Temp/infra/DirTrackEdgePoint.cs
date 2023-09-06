using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using infra;

namespace infra
{
    public class DirTrackEdgePoint
    {
        public TrackEdgePoint? trackEdgePoint;
        [XmlAttribute]
        public Direction direction;
    }
}
