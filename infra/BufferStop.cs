using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "bufferStop")]
	public class BufferStop
	{
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string trackEdge {get;set;}
		[XmlAttribute]
		public uint pos {get;set;}
		[XmlAttribute]
		public bool sameDir {get;set;}
		[XmlAttribute]
		public bool isSwitchable {get;set;}
	}
}