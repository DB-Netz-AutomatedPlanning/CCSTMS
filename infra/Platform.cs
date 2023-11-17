using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "platform")]
	public class Platform
	{
		[XmlArrayItem("platformEdge", Namespace = "https://erju.org/infra")]
		public List<infra.PlatformEdge> platformEdges;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string name {get;set;}
	}
}