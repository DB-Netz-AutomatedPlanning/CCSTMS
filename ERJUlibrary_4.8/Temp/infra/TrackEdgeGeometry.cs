using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeGeometry")]
	public class TrackEdgeGeometry
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
        [XmlArrayItem("horizontalSegment", Namespace = "https://erju.org/infra")]
        public List<HorizontalSegment> horizontalAlignment;
        [XmlArrayItem("certicalSegment", Namespace = "https://erju.org/infra")]
        public List<VerticalSegment> verticalAlignment;
        [XmlArrayItem("cantSamplePoint", Namespace = "https://erju.org/infra")]
        public List<CantSamplePoint> cantSamples;
	}
}
