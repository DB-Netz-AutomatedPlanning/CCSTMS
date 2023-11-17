using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdge")]
	public class TrackEdge
	{
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public uint length {get;set;}
	}
}