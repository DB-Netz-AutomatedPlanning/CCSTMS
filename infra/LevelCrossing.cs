using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "levelCrossing")]
	public class LevelCrossing
	{
		[XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/infra")]
		public List<infra.TrackEdgeSection> trackEdgeSections;
		[XmlAttribute]
		public string id {get;set;}
	}
}