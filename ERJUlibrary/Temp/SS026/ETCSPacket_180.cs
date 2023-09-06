using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_180")]
	public class ETCSPacket_180
	{		
		[XmlAttribute]
		public bool q_lssma;		
		[XmlAttribute]
		public uint t_lssma;
}