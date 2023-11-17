using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "balisePacket")]
	public class BalisePacket
	{
		public ss026.Packet? packet {get;set;}
		[XmlAttribute]
		public uint nid {get;set;}
		[XmlAttribute]
		public ss026.QDir q_dir {get;set;}
	}
}