using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "nationalBorder")]
	public class NationalBorder
	{
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string trackEdge {get;set;}
		[XmlAttribute]
		public uint pos {get;set;}
		[XmlAttribute]
		public string fromCountryCode {get;set;}
		[XmlAttribute]
		public string toCountryCode {get;set;}
	}
}