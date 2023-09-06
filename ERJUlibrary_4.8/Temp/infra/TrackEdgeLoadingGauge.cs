using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeLoadingGauge")]
	public class TrackEdgeLoadingGauge
	{
        [XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/infra")]
        public List<TrackEdgeSection> trackSections;
        [XmlAttribute]
        public LoadingGaugeType loadingGaugeType;
	}
}
