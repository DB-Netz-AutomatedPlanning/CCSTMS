using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "horizontalSegment")]
	public struct HorizontalSegment
	{		
		public HorizontalLine line;		
		public HorizontalArc arc;		
		public HorizontalTransition transition;
	}
}