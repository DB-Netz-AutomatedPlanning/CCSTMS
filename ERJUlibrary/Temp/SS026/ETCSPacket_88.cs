using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_88")]
	public class ETCSPacket_88
	{		
		[XmlAttribute]
		public uint nid_lx;		
		[XmlAttribute]
		public uint d_lx;		
		[XmlAttribute]
		public uint l_lx;		
		public LXStatus? lxStatus;
}