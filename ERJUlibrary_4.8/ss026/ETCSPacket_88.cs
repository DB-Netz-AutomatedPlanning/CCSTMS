using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_88")]
	public class ETCSPacket_88
	{
		[XmlAttribute]
		public uint nid_lx;
		[XmlAttribute]
		public uint d_lx;
		[XmlAttribute]
		public uint l_lx;

		public LXStatus lxStatus;

	}
}
