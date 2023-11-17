using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "verticalArc")]
	public class VerticalArc
	{
		[XmlAttribute]
		public double pos {get;set;}
		[XmlAttribute]
		public double slope {get;set;}
		[XmlAttribute]
		public double radius {get;set;}
	}
}