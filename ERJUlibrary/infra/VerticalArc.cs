using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "verticalArc")]
	public class VerticalArc
	{
		[XmlAttribute]
		public double pos;
		[XmlAttribute]
		public double slope;
		[XmlAttribute]
		public double radius;

	}
}
