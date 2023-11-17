using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeSpeedProfile")]
	public class TrackEdgeSpeedProfile
	{
		[XmlArrayItem("staticSpeedProfileItem", Namespace = "https://erju.org/infra")]
		public List<infra.StaticSpeedLimit> staticSpeedProfile;
		[XmlArrayItem("axleLoadSpeedProfile", Namespace = "https://erju.org/infra")]
		public List<infra.AxleLoadSpeedProfile> axleLoadSpeedProfiles;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public bool sameDir {get;set;}
	}
}