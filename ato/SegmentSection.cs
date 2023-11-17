using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "segmentSection")]
	public class SegmentSection
	{
		[XmlAttribute]
		public ato.RangeType range {get;set;}
		[XmlAttribute]
		public uint pStart {get;set;}
		[XmlAttribute]
		public uint pEnd {get;set;}
	}
}