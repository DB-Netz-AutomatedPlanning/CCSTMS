using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "simplePoint")]
	public class SimplePoint
	{
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public uint reversalTime {get;set;}
		[XmlAttribute]
		public string mainTrack {get;set;}
		[XmlAttribute]
		public string branchTrack {get;set;}
	}
}