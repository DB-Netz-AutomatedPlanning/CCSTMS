using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_133")]
	public class ETCSPacket_133
	{		
		[XmlAttribute]
		public bool q_riu;		
		[XmlAttribute]
		public uint nid_c;		
		[XmlAttribute]
		public uint nid_riu;		
		[XmlAttribute]
		public uint nid_radio;		
		[XmlAttribute]
		public uint d_infill;		
		[XmlAttribute]
		public uint nid_c_2;		
		[XmlAttribute]
		public uint nid_bg;
}