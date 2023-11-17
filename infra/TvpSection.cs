using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "tvpSection")]
	public class TvpSection
	{
		[XmlArrayItem("trackSection", Namespace = "https://erju.org/infra")]
		public List<infra.TrackEdgeSection> trackSections;
		[XmlArrayItem("trainDetector", Namespace = "https://erju.org/infra")]
		public List<TrainDetectorRef> trainDetectors;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string name {get;set;}
	}
}