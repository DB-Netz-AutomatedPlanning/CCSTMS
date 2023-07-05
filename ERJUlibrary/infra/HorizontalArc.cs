using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "horizontalArc")]
	public class HorizontalArc
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public uint azimuth;		
		[XmlAttribute]
		public int radius;
	}
}