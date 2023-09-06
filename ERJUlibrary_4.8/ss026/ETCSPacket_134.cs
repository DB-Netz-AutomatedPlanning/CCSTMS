using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_134")]
	public class ETCSPacket_134
	{
		[XmlAttribute]
		public uint nid_loop;
		[XmlAttribute]
		public uint d_loop;
		[XmlAttribute]
		public uint l_loop;
		[XmlAttribute]
		public bool q_loopdir;
		[XmlAttribute]
		public uint q_sscode;

	}
}
