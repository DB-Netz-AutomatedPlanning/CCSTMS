using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_41")]
	public class ETCSPacket_41
	{
		[XmlArrayItem("levelTransition", Namespace = "https://erju.org/ss026")]
		public List<ss026.LevelTransitionWithAck> levelTransitions;
		[XmlAttribute]
		public uint d_leveltr {get;set;}
		[XmlAttribute]
		public ss026.EtcsLevel m_leveltr {get;set;}
		[XmlAttribute]
		public uint nid_ntc {get;set;}
		[XmlAttribute]
		public uint l_ackleveltr {get;set;}
	}
}