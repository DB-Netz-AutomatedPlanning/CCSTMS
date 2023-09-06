using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeGauge")]
	public class TrackEdgeGauge
	{
		[XmlArrayItem("trackSection", Namespace = "https://erju.org/infra")]
		public List<TrackEdgeSection> trackSections;
		[XmlAttribute]
		public uint gauge;

	}
}
