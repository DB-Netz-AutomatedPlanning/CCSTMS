using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_70")]
	public class ETCSPacket_70
	{		
		[XmlArrayItem("routeSuitability", Namespace = "https://erju.org/")]
		public List<RouteSuitability>? routeSuitabilities;		
		[XmlAttribute]
		public uint d_trackinit;
}