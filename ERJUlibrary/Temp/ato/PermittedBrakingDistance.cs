using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "permittedBrakingDistance")]
	public class PermittedBrakingDistance
	{		
		public SegmentSection? segmentSection;		
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