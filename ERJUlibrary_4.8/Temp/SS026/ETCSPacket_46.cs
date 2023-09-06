using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_46")]
	public class ETCSPacket_46
	{		
		[XmlAttribute]
		public EtcsLevel m_leveltr;		
		[XmlAttribute]
		public uint nid_ntc;		
		[XmlArrayItem("levelTransition", Namespace = "https://erju.org/")]
		public List<LevelTransition>? levelTransitions;
}