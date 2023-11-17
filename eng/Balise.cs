using System.Xml.Serialization;
using System.Collections.Generic;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "balise")]
	public class Balise
	{
		[XmlArrayItem("etcsPacket", Namespace = "https://erju.org/eng")]
		public List<ss026.BalisePacket> etcsPackets;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute(AttributeName = "fixed")]
		public bool _fixed {get;set;}
		[XmlAttribute]
		public bool q_updown {get;set;}
		[XmlAttribute]
		public eng.DuplicationType m_dup {get;set;}
		[XmlAttribute]
		public uint m_mcount {get;set;}
		[XmlAttribute]
		public bool verticallyOriented {get;set;}
		[XmlAttribute]
		public bool standardSize {get;set;}
	}
}