using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "geometryArea")]
	public class GeometryArea
	{
		[XmlArrayItem("trackEdgeGeometry", Namespace = "https://erju.org/infra")]
		public List<infra.TrackEdgeGeometry> trackEdgeGeometries;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public bool alignment3d {get;set;}
	}
}