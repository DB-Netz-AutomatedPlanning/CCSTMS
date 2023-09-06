using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeGeometry")]
	public class TrackEdgeGeometry
	{
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
				return this.id != null?  this.id : "";
			}
}
		[XmlArrayItem("horizontalAlignmentItem", Namespace = "https://erju.org/infra")]
		public List<HorizontalSegment> horizontalAlignment;
		[XmlArrayItem("verticalAlignmentItem", Namespace = "https://erju.org/infra")]
		public List<VerticalSegment> verticalAlignment;
		[XmlArrayItem("cantSample", Namespace = "https://erju.org/infra")]
		public List<CantSamplePoint> cantSamples;

	}
}
