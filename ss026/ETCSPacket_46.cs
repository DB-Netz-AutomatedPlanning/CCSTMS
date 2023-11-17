using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_46")]
	public class ETCSPacket_46
	{
		[XmlArrayItem("levelTransition", Namespace = "https://erju.org/ss026")]
		public List<ss026.LevelTransition> levelTransitions;
		[XmlAttribute]
		public ss026.EtcsLevel m_leveltr {get;set;}
		[XmlAttribute]
		public uint nid_ntc {get;set;}
	}
}