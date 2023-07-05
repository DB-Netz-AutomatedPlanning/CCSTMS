using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "verticalSegment")]
	public class VerticalSegment
	{		
		public VerticalLine? line;		
		public VerticalArc? arc;
	}
}