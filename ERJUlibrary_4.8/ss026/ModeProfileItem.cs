using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "modeProfileItem")]
	public class ModeProfileItem
	{
		[XmlAttribute]
		public uint d_mamode;
		[XmlAttribute]
		public MAMode m_mamode;
		[XmlAttribute]
		public uint v_mamode;
		[XmlAttribute]
		public uint l_mamode;
		[XmlAttribute]
		public uint l_ackmamode;
		[XmlAttribute]
		public bool q_mamode;

	}
}
