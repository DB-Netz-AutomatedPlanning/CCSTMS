using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "sampledTrackEdgeGeometry")]
	public class SampledTrackEdgeGeometry
	{		
		private string trackEdge;
		[XmlAttribute(AttributeName = "trackEdge")]
		public string TrackEdge
        {
            set
            {
                this.trackEdge = value;
            }
            get
            {
                return this.trackEdge != null?  this.trackEdge : "";   
            }
        
        }
        [XmlArrayItem("slopeSamplePoint", Namespace = "https://erju.org/infra")]
        public List<SlopeSamplePoint> slopes;
        [XmlArrayItem("curveSamplePoint", Namespace = "https://erju.org/infra")]
        public List<CurveSamplePoint> curves;
        [XmlArrayItem("cantSamplePoint", Namespace = "https://erju.org/infra")]
        public List<CantSamplePoint> cants;
	}
}
