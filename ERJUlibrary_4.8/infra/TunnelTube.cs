using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "tunnelTube")]
	public class TunnelTube
	{		
		[XmlAttribute]
		public uint id;		
		public TunnelPortal startTunnelPortal;		
		public TunnelPortal endTunnelPortal;		
		[XmlAttribute]
		public uint numberOfTracks;		
		[XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/infra")]
		public List<TrackEdgeSection> trackSections;		
		[XmlAttribute]
		public uint tubeLength;		
		[XmlAttribute]
		public uint crossSection;
	}
}
