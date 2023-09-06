using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_42")]
	public class ETCSPacket_42
	{
		[XmlAttribute]
		public bool q_rbc;
		[XmlAttribute]
		public uint nid_c;
		[XmlAttribute]
		public uint nid_rbc;
		[XmlAttribute]
		public uint nid_radio;
		[XmlAttribute]
		public bool q_sleepsession;

	}
}
