using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "underpass")]
	public class Underpass
	{
		[XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/infra")]
		public List<infra.TrackEdgeSection> trackEdgeSections;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string name {get;set;}
	}
}