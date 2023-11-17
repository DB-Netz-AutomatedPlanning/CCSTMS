using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_133")]
	public class ETCSPacket_133
	{
		[XmlAttribute]
		public bool q_riu {get;set;}
		[XmlAttribute]
		public uint nid_c {get;set;}
		[XmlAttribute]
		public uint nid_riu {get;set;}
		[XmlAttribute]
		public uint nid_radio {get;set;}
		[XmlAttribute]
		public uint d_infill {get;set;}
		[XmlAttribute]
		public uint nid_bg {get;set;}
	}
}