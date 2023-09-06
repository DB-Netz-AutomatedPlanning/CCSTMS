using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_71")]
	public class ETCSPacket_71
	{		
		[XmlAttribute]
		public uint d_adhesion;		
		[XmlAttribute]
		public uint l_adhesion;		
		[XmlAttribute]
		public bool m_adhesion;
}