using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_131")]
	public class ETCSPacket_131
	{
		[XmlAttribute]
		public uint d_rbctr {get;set;}
		[XmlAttribute]
		public uint nid_c {get;set;}
		[XmlAttribute]
		public uint nid_rbc {get;set;}
		[XmlAttribute]
		public uint nid_radio {get;set;}
		[XmlAttribute]
		public bool q_sleepsession {get;set;}
	}
}