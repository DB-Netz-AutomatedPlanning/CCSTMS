using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_6")]
	public class ETCSPacket_6
	{		
		[XmlAttribute]
		public uint nid_c;		
		public ValidityPeriod? validityPeriod;
}