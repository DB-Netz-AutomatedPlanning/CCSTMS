using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "sampledTrackEdgeGeometry")]
	public class SampledTrackEdgeGeometry
	{
        [XmlAttribute]
        private string id;
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id != null ? this.id : "";
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
