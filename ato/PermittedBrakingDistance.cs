using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "permittedBrakingDistance")]
	public class PermittedBrakingDistance
	{
		public ato.SegmentSection? segmentSection {get;set;}
		[XmlAttribute]
		public uint value {get;set;}
		[XmlAttribute]
		public bool byEmergencyBrake {get;set;}
		[XmlAttribute]
		public uint gradient {get;set;}
		[XmlAttribute]
		public bool uphillGradient {get;set;}
	}
}