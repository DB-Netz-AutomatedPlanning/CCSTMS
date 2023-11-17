using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "horizontalSegment")]
	public class HorizontalSegment
	{
		public infra.HorizontalLine? line {get;set;}
		public infra.HorizontalArc? arc {get;set;}
		public infra.HorizontalTransition? transition {get;set;}
	}
}