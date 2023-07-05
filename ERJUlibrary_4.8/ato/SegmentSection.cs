using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "segmentSection")]
	public class SegmentSection
	{		
		[XmlAttribute]
		public RangeType range;		
		[XmlAttribute]
		public uint pStart;		
		[XmlAttribute]
		public uint pEnd;
	}
}
