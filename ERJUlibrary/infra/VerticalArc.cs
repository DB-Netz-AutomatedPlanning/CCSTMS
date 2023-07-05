using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "verticalArc")]
	public class VerticalArc
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public int slope;		
		[XmlAttribute]
		public int radius;
	}
}