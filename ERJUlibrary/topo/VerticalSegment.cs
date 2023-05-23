using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "verticalSegment")]
	public struct VerticalSegment
	{		
		public VerticalLine line;		
		public VerticalArc arc;
	}
}