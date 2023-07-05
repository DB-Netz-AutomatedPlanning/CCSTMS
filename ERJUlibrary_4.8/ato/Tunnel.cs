using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "tunnel")]
	public class Tunnel
	{		
		public SegmentSection segmentSection;		
		[XmlAttribute]
		public TunnelType type;
	}
}
