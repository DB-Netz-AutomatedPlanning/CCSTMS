using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_134")]
	public class ETCSPacket_134
	{
		[XmlAttribute]
		public uint nid_loop {get;set;}
		[XmlAttribute]
		public uint d_loop {get;set;}
		[XmlAttribute]
		public uint l_loop {get;set;}
		[XmlAttribute]
		public bool q_loopdir {get;set;}
		[XmlAttribute]
		public uint q_sscode {get;set;}
	}
}