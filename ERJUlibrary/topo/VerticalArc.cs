using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "verticalArc")]
	public struct VerticalArc
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public int slope;		
		[XmlAttribute]
		public uint radius;
	}
}