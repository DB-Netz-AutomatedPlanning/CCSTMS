using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_2")]
	public class ETCSPacket_2
	{		
		[XmlAttribute]
		public ETCSVersion m_version;
}