using System.Xml.Serialization;
using System.Collections.Generic;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "mileageLine")]
	public class MileageLine
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
		[XmlArrayItem("trackEdge", Namespace = "https://erju.org/eng")]
		public List<TrackEdgeMileage> trackEdges;
		[XmlArrayItem("horizontalGeometryItem", Namespace = "https://erju.org/eng")]
		public List<infra.HorizontalSegment> horizontalGeometry;
		[XmlArrayItem("referenceMarker", Namespace = "https://erju.org/eng")]
		public List<MileageReferenceMarker> referenceMarkers;

	}
}
