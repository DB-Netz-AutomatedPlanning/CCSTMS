using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeLink")]
	public class TrackEdgeLink
	{
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string trackEdgeA {get;set;}
		[XmlAttribute]
		public string trackEdgeB {get;set;}
		[XmlAttribute]
		public bool startOfA {get;set;}
		[XmlAttribute]
		public bool startOfB {get;set;}
		[XmlAttribute]
		public infra.LinkDirection usableDir {get;set;}
	}
}