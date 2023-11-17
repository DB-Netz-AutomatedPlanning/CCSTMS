using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "timingPoint")]
	public class TimingPoint
	{
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string trackEdge {get;set;}
		[XmlAttribute]
		public uint pos {get;set;}
	}
}