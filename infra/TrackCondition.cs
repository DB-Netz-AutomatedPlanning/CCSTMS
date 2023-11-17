using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackCondition")]
	public class TrackCondition
	{
		[XmlArrayItem("trackSection", Namespace = "https://erju.org/infra")]
		public List<infra.TrackEdgeSection> trackSections;
		[XmlAttribute]
		public infra.ConditionType type {get;set;}
	}
}