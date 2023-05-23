using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "verticalLine")]
	public struct VerticalLine
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public int slope;
	}
}