using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "horizontalArc")]
	public struct HorizontalArc
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public uint azimuth;		
		[XmlAttribute]
		public uint radius;
	}
}