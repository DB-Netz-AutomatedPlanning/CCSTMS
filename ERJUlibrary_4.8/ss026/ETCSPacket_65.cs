using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_65")]
	public class ETCSPacket_65
	{
		[XmlAttribute]
		public uint nid_tsr;
		[XmlAttribute]
		public uint d_tsr;
		[XmlAttribute]
		public uint l_tsr;
		[XmlAttribute]
		public bool q_front;
		[XmlAttribute]
		public uint v_tsr;

	}
}
