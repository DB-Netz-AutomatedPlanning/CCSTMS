using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeGeometry")]
	public class TrackEdgeGeometry
	{		
		private string? trackEdge;
		[XmlAttribute(AttributeName = "trackEdge")]
		public string TrackEdge
        {
            set
            {
                this.trackEdge = value;
            }
            get
            {
                return this.trackEdge != null ? this.trackEdge : "";   
            }
        
        }
        [XmlArrayItem("horizontalSegment", Namespace = "https://erju.org/infra")]
        public List<HorizontalSegment>? horizontalAlignment;
        [XmlArrayItem("certicalSegment", Namespace = "https://erju.org/infra")]
        public List<VerticalSegment>? verticalAlignment;
        [XmlArrayItem("cantSamplePoint", Namespace = "https://erju.org/infra")]
        public List<CantSamplePoint>? cantSamples;
	}
}