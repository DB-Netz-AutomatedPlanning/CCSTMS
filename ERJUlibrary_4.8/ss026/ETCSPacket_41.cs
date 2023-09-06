using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_41")]
	public class ETCSPacket_41
	{
		[XmlAttribute]
		public uint d_leveltr;
		[XmlAttribute]
		public EtcsLevel m_leveltr;
		[XmlAttribute]
		public uint nid_ntc;
		[XmlAttribute]
		public uint l_ackleveltr;
		[XmlArrayItem("levelTransition", Namespace = "https://erju.org/ss026")]
		public List<LevelTransitionWithAck> levelTransitions;

	}
}
