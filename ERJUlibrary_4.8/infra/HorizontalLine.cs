using System.Xml.Serialization;
using System.Collections.Generic;
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
