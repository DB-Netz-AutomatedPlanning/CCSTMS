using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_46")]
	public class ETCSPacket_46
	{
		[XmlAttribute]
		public EtcsLevel m_leveltr;
		[XmlAttribute]
		public uint nid_ntc;
		[XmlArrayItem("levelTransition", Namespace = "https://erju.org/ss026")]
		public List<LevelTransition> levelTransitions;

	}
}
