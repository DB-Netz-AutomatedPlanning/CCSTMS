using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "tractionSystem")]
	public class TractionSystem
	{
		[XmlArrayItem("trackSection", Namespace = "https://erju.org/infra")]
		public List<infra.TrackEdgeSection> trackSections;
		[XmlAttribute]
		public infra.VoltageType type {get;set;}
	}
}