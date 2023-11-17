using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "propertiesArea")]
	public class PropertiesArea
	{
		[XmlArrayItem("trackEdgeGauge", Namespace = "https://erju.org/infra")]
		public List<infra.TrackEdgeGauge> trackEdgeGauges;
		[XmlArrayItem("trackEdgeLoadingGauge", Namespace = "https://erju.org/infra")]
		public List<infra.TrackEdgeLoadingGauge> trackEdgeLoadingGauges;
		[XmlArrayItem("trackCondition", Namespace = "https://erju.org/infra")]
		public List<infra.TrackCondition> trackConditions;
		[XmlArrayItem("secondaryTrack", Namespace = "https://erju.org/infra")]
		public List<SecondaryTrackRef> secondaryTracks;
		[XmlArrayItem("shuntingTrack", Namespace = "https://erju.org/infra")]
		public List<ShuntingTrackRef> shuntingTracks;
		[XmlArrayItem("currentLimitation", Namespace = "https://erju.org/infra")]
		public List<infra.CurrentLimitation> currentLimitations;
		[XmlArrayItem("permittedBrakingDistance", Namespace = "https://erju.org/infra")]
		public List<infra.PermittedBrakingDistance> permittedBrakingDistances;
		[XmlArrayItem("preferredSameDi", Namespace = "https://erju.org/infra")]
		public List<PreferredSameDiRef> preferredSameDir;
		[XmlArrayItem("preferredOppositeDi", Namespace = "https://erju.org/infra")]
		public List<PreferredOppositeDiRef> preferredOppositeDir;
		[XmlArrayItem("tractionSystem", Namespace = "https://erju.org/infra")]
		public List<infra.TractionSystem> tractionSystems;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public uint gauge {get;set;}
		[XmlAttribute]
		public infra.LoadingGaugeType loadingGaugeType {get;set;}
	}
}