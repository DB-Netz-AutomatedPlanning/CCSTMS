using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "limitedDynamicBrakeForce")]
	public class LimitedDynamicBrakeForce
	{
		public ato.SegmentSection? segmentSection {get;set;}
		[XmlAttribute]
		public uint dynamicBrakeForceLimit {get;set;}
	}
}