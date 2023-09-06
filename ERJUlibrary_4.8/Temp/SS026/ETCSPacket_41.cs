using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_41")]
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
		[XmlArrayItem("levelTransitionWithAck", Namespace = "https://erju.org/")]
		public List<LevelTransitionWithAck>? levelTransitions;
}