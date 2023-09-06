using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "limitedDynamicBrakeForce")]
	public class LimitedDynamicBrakeForce
	{		
		public SegmentSection segmentSection;		
		[XmlAttribute]
		public uint dynamicBrakeForceLimit;
	}
}
