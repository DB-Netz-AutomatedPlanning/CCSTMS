using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "verticalSegment")]
	public class VerticalSegment
	{
				public VerticalLine line;
				public VerticalArc arc;

	}
}
