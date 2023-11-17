using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeProjection")]
	public class TrackEdgeProjection
	{
		[XmlArrayItem("coordinate", Namespace = "https://erju.org/infra")]
		public List<infra.TrackEdgeCoordinate> coordinates;
		[XmlAttribute]
		public string id {get;set;}
	}
}