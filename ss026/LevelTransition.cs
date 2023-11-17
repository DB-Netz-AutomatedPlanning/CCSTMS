using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "levelTransition")]
	public class LevelTransition
	{
		[XmlAttribute]
		public ss026.EtcsLevel m_leveltr {get;set;}
		[XmlAttribute]
		public uint nid_ntc_k {get;set;}
	}
}