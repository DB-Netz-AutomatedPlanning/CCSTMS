using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "mapArea")]
	public class MapArea
	{
		[XmlArrayItem("trackEdge", Namespace = "https://erju.org/infra")]
		public List<infra.TrackEdgeProjection> trackEdges;
		[XmlArrayItem("funcElement", Namespace = "https://erju.org/infra")]
		public List<infra.FuncElementProjection> funcElements;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string name {get;set;}
		[XmlAttribute]
		public string areaId {get;set;}
		[XmlAttribute]
		public uint epsg {get;set;}
	}
}