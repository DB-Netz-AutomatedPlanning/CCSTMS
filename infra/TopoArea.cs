using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "topoArea")]
	public class TopoArea
	{
		[XmlArrayItem("trackEdge", Namespace = "https://erju.org/infra")]
		public List<infra.TrackEdge> trackEdges;
		[XmlArrayItem("trackEdgeLink", Namespace = "https://erju.org/infra")]
		public List<infra.TrackEdgeLink> trackEdgeLinks;
		[XmlAttribute]
		public string id {get;set;}
	}
}