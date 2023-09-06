using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "horizontalTransition")]
	public class HorizontalTransition
	{
		[XmlAttribute]
		public double pos;
		[XmlAttribute]
		public double azimuth;
		[XmlAttribute]
		public double radius;
		[XmlAttribute]
		public TransitionType type;

	}
}
