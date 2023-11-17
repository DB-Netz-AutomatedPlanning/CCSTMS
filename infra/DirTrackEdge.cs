using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "dirTrackEdge")]
	public class DirTrackEdge
	{
		[XmlAttribute]
		public string trackEdge {get;set;}
		[XmlAttribute]
		public bool sameDir {get;set;}
	}
}