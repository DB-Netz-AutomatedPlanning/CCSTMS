using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_139")]
	public class ETCSPacket_139
	{		
		[XmlAttribute]
		public uint d_reverse;		
		[XmlAttribute]
		public uint v_reverse;
}