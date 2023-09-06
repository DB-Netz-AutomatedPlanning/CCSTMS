using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "aTOSegment")]
	public class ATOSegment
	{		
		[XmlAttribute]
		public uint id;		
		[XmlAttribute]
		public bool sameDir;		
		public infra.TrackEdgeSection trackSection;		
		public SegmentProfile segmentProfile;
	}
}
