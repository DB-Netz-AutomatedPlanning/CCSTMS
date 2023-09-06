using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "horizontalSegment")]
	public class HorizontalSegment
	{		
		public HorizontalLine? line;		
		public HorizontalArc? arc;		
		public HorizontalTransition? transition;
	}
}