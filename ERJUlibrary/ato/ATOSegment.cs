using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "aTOSegment")]
	public class ATOSegment
	{		
		[XmlAttribute]
		public uint id;		
		[XmlAttribute]
		public bool sameDir;		
		public infra.TrackEdgeSection? trackSection;		
		public SegmentProfile? segmentProfile;
	}
}