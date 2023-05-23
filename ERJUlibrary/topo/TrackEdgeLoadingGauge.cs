using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "trackEdgeLoadingGauge")]
	public struct TrackEdgeLoadingGauge
	{		
		public List<TrackEdgeSection> trackSections;
        [XmlAttribute]
        public LoadingGaugeType loadingGaugeType;
	}
}