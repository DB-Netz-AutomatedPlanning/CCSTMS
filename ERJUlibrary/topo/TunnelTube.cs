using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "tunnelTube")]
	public struct TunnelTube
	{		
		[XmlAttribute]
		public uint id;		
		public TunnelPortal startTunnelPortal;		
		public TunnelPortal endTunnelPortal;		
		[XmlAttribute]
		public uint numberOfTracks;		
		[XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/topo")]
		public List<TrackEdgeSection> trackSections;		
		[XmlAttribute]
		public uint tubeLength;		
		[XmlAttribute]
		public uint crossSection;
	}
}