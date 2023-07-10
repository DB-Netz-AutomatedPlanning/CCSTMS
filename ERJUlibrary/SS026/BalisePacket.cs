using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "balisePacket")]
	public class BalisePacket
	{		
		[XmlAttribute]
		public uint nid;		
		[XmlAttribute]
		public QDir q_dir;		
		public Packet? packet;
}