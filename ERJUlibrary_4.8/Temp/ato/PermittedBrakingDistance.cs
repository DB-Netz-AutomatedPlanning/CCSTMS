using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "permittedBrakingDistance")]
	public class PermittedBrakingDistance
	{		
		public SegmentSection segmentSection;		
		[XmlAttribute]
		public uint value;		
		[XmlAttribute]
		public bool byEmergencyBrake;		
		[XmlAttribute]
		public uint gradient;		
		[XmlAttribute]
		public bool uphillGradient;
	}
}
