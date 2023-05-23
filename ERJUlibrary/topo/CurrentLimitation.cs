using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "currentLimitation")]
	public struct CurrentLimitation
	{		
		public List<TrackEdgeSection> trackSections;		
		[XmlAttribute]
		public uint maxCurrent;
	}
}