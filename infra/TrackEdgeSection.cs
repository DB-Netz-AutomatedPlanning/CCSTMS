using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeSection")]
	public class TrackEdgeSection
	{
		[XmlAttribute]
		public string trackEdge {get;set;}
		[XmlAttribute]
		public uint skipFromPathStart {get;set;}
		[XmlAttribute]
		public uint skipFromPathEnd {get;set;}
	}
}