using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "tunnelTube")]
	public class TunnelTube
	{						
		[XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/infra")]
		public List<TrackEdgeSection> trackSections;				
		[XmlAttribute]
		public uint crossSection;
	}
}
