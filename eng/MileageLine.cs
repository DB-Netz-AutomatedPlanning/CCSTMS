using System.Xml.Serialization;
using System.Collections.Generic;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "mileageLine")]
	public class MileageLine
	{
		[XmlArrayItem("trackEdge", Namespace = "https://erju.org/eng")]
		public List<eng.TrackEdgeMileage> trackEdges;
		[XmlArrayItem("horizontalGeometryItem", Namespace = "https://erju.org/eng")]
		public List<infra.HorizontalSegment> horizontalGeometry;
		[XmlArrayItem("referenceMarker", Namespace = "https://erju.org/eng")]
		public List<eng.MileageReferenceMarker> referenceMarkers;
		[XmlAttribute]
		public string id {get;set;}
	}
}