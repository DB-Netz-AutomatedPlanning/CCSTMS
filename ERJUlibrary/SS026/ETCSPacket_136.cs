using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_136")]
	public class ETCSPacket_136
	{		
		public NewCountry? newCountry;		
		[XmlAttribute]
		public uint nid_bg;
}