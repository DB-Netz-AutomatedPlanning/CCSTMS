using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeGeometry")]
	public class TrackEdgeGeometry
	{
		[XmlArrayItem("horizontalAlignmentItem", Namespace = "https://erju.org/infra")]
		public List<infra.HorizontalSegment> horizontalAlignment;
		[XmlArrayItem("verticalAlignmentItem", Namespace = "https://erju.org/infra")]
		public List<infra.VerticalSegment> verticalAlignment;
		[XmlArrayItem("cantSample", Namespace = "https://erju.org/infra")]
		public List<infra.CantSamplePoint> cantSamples;
		[XmlAttribute]
		public string id {get;set;}
	}
}