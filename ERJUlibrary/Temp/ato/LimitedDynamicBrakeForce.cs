using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "limitedDynamicBrakeForce")]
	public class LimitedDynamicBrakeForce
	{		
		public SegmentSection? segmentSection;		
		[XmlAttribute]
		public uint dynamicBrakeForceLimit;
	}
}