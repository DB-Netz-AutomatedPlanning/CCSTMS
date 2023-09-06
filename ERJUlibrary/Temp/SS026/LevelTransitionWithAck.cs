using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "levelTransitionWithAck")]
	public class LevelTransitionWithAck
	{		
		[XmlAttribute]
		public EtcsLevel m_leveltr;		
		[XmlAttribute]
		public uint nid_ntc_k;		
		[XmlAttribute]
		public uint l_ackleveltr_k;
}