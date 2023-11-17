using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_39")]
	public class ETCSPacket_39
	{
		[XmlAttribute]
		public uint d_traction {get;set;}
		[XmlAttribute]
		public ss026.VoltageType m_voltage {get;set;}
		[XmlAttribute]
		public uint nid_ctraction {get;set;}
	}
}