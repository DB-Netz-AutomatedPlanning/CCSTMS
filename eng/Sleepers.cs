using System.Xml.Serialization;
using System.Collections.Generic;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "sleepers")]
	public class Sleepers
	{
		[XmlArrayItem("trackEdgeSectionItem", Namespace = "https://erju.org/eng")]
		public List<infra.TrackEdgeSection> trackEdgeSection;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public eng.SleepersType type {get;set;}
	}
}