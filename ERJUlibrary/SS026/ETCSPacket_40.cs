using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_40")]
	public class ETCSPacket_40
	{		
		[XmlAttribute]
		public uint d_current;		
		[XmlAttribute]
		public uint m_current;
}