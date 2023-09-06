using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_134")]
	public class ETCSPacket_134
	{		
		[XmlAttribute]
		public uint nid_loop;		
		[XmlAttribute]
		public uint d_loop;		
		[XmlAttribute]
		public uint l_loop;		
		[XmlAttribute]
		public bool q_loopdir;		
		[XmlAttribute]
		public uint q_sscode;
}