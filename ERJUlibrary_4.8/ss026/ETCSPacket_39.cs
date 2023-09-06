using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_39")]
	public class ETCSPacket_39
	{
		[XmlAttribute]
		public uint d_traction;
		[XmlAttribute]
		public VoltageType m_voltage;
		[XmlAttribute]
		public uint nid_ctraction;

	}
}
