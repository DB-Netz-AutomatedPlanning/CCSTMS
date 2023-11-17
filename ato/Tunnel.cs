using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "tunnel")]
	public class Tunnel
	{
		public ato.SegmentSection? segmentSection {get;set;}
		[XmlAttribute]
		public ato.TunnelType type {get;set;}
	}
}