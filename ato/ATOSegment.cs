using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "aTOSegment")]
	public class ATOSegment
	{
		public infra.TrackEdgeSection? trackSection {get;set;}
		public ato.SegmentProfile? segmentProfile {get;set;}
		[XmlAttribute]
		public uint id {get;set;}
		[XmlAttribute]
		public bool sameDir {get;set;}
	}
}