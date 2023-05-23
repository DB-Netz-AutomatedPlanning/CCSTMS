using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "horizontalLine")]
	public struct HorizontalLine
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public int azimuth;
	}
}