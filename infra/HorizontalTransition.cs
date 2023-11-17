using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "horizontalTransition")]
	public class HorizontalTransition
	{
		[XmlAttribute]
		public double pos {get;set;}
		[XmlAttribute]
		public double azimuth {get;set;}
		[XmlAttribute]
		public double radius {get;set;}
		[XmlAttribute]
		public infra.TransitionType type {get;set;}
	}
}