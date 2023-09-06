using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "levelTransition")]
	public class LevelTransition
	{
		[XmlAttribute]
		public EtcsLevel m_leveltr;
		[XmlAttribute]
		public uint nid_ntc_k;

	}
}
