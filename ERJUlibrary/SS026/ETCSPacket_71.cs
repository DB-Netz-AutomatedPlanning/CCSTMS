using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_71")]
	public class ETCSPacket_71
	{
		[XmlAttribute]
		public uint d_adhesion;
		[XmlAttribute]
		public uint l_adhesion;
		[XmlAttribute]
		public bool m_adhesion;

	}
}
