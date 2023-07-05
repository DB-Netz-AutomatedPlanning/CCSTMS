using System.Xml.Serialization;
using System.Collections.Generic;
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
