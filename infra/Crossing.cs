using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "crossing")]
	public class Crossing
	{
		[XmlArrayItem("trackEdgePoint", Namespace = "https://erju.org/infra")]
		public List<infra.TrackEdgePoint> trackEdgePoints;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public bool isSwitchable {get;set;}
	}
}