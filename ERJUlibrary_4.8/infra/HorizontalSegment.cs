using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "horizontalSegment")]
	public class HorizontalSegment
	{
				public HorizontalLine line;
				public HorizontalArc arc;
				public HorizontalTransition transition;

	}
}
