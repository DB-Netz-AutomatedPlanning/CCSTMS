using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_39")]
	public class ETCSPacket_39
	{		
		[XmlAttribute]
		public uint d_traction;
		[XmlAttribute]
		public VoltageType m_voltage;		
		[XmlAttribute]
		public uint nid_ctraction;
}