using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_131")]
	public class ETCSPacket_131
	{		
		[XmlAttribute]
		public uint d_rbctr;		
		[XmlAttribute]
		public uint nid_c;		
		[XmlAttribute]
		public uint nid_rbc;		
		[XmlAttribute]
		public uint nid_radio;		
		[XmlAttribute]
		public bool q_sleepsession;
}