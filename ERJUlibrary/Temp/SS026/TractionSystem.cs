using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "tractionSystem")]
	public class TractionSystem
	{		
		[XmlAttribute]
		public VoltageType d_voltage;		
		[XmlAttribute]
		public uint nid_ctraction;
}