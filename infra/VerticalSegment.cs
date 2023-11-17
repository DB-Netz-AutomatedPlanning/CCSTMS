using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "verticalSegment")]
	public class VerticalSegment
	{
		public infra.VerticalLine? line {get;set;}
		public infra.VerticalArc? arc {get;set;}
	}
}