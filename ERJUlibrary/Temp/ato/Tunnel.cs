using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "tunnel")]
	public class Tunnel
	{		
		public SegmentSection? segmentSection;		
		[XmlAttribute]
		public TunnelType type;
	}
}