using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "trackEdgeGauge")]
	public struct TrackEdgeGauge
	{		
		public List<TrackEdgeSection> trackSections;		
		[XmlAttribute]
		public uint gauge;
	}
}