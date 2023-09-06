using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "levelTransition")]
	public class LevelTransition
	{
		[XmlAttribute]
		public EtcsLevel m_leveltr;		
		[XmlAttribute]
		public uint nid_ntc_k;
}