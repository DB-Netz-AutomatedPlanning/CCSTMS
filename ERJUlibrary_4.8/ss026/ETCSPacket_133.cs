using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_133")]
	public class ETCSPacket_133
	{
		[XmlAttribute]
		public bool q_riu;
		[XmlAttribute]
		public uint nid_c;
		[XmlAttribute]
		public uint nid_riu;
		[XmlAttribute]
		public uint nid_radio;
		[XmlAttribute]
		public uint d_infill;
		[XmlAttribute]
		public uint nid_bg;

	}
}
