using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "horizontalArc")]
	public class HorizontalArc
	{		
		[XmlAttribute]
		public uint pos;		
		[XmlAttribute]
		public uint azimuth;		
	}
}
