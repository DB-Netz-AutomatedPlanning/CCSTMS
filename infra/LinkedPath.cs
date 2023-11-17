using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "linkedPath")]
	public class LinkedPath
	{
		[XmlArrayItem("dirTrackEdge", Namespace = "https://erju.org/infra")]
		public List<infra.DirTrackEdge> dirTrackEdges;
		[XmlAttribute]
		public uint skipFromPathStart {get;set;}
		[XmlAttribute]
		public uint skipFromPathEnd {get;set;}
	}
}