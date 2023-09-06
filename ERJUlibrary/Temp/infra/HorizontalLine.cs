using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "horizontalLine")]
	public class HorizontalLine
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public int azimuth;
	}
}