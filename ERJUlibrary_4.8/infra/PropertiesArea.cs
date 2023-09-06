using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "propertiesArea")]
	public class PropertiesArea
	{
		private string id;
		[XmlAttribute(AttributeName = "id")]
		public string Id
		{
			set
			{
				this.id = value;
			}
			get
			{
				return this.id != null?  this.id : "";
			}
}
		private string name;
		[XmlAttribute(AttributeName = "name")]
		public string Name
		{
			set
			{
				this.name = value;
			}
			get
			{
				return this.name != null?  this.name : "";
			}
}
		[XmlAttribute]
		public uint gauge;
		[XmlAttribute]
		public LoadingGaugeType loadingGaugeType;
		[XmlArrayItem("trackEdgeGauge", Namespace = "https://erju.org/infra")]
		public List<TrackEdgeGauge> trackEdgeGauges;
		[XmlArrayItem("trackEdgeLoadingGauge", Namespace = "https://erju.org/infra")]
		public List<TrackEdgeLoadingGauge> trackEdgeLoadingGauges;
		[XmlArrayItem("trackCondition", Namespace = "https://erju.org/infra")]
		public List<TrackCondition> trackConditions;
		[XmlArrayItem("secondaryTrack", Namespace = "https://erju.org/infra")]
		public List<TrackEdgeRef> secondaryTracks;
		[XmlArrayItem("shuntingTrack", Namespace = "https://erju.org/infra")]
		public List<TrackEdgeRef> shuntingTracks;
		[XmlArrayItem("currentLimitation", Namespace = "https://erju.org/infra")]
		public List<CurrentLimitation> currentLimitations;
		[XmlArrayItem("permittedBrakingDistance", Namespace = "https://erju.org/infra")]
		public List<PermittedBrakingDistance> permittedBrakingDistances;
		[XmlArrayItem("preferredSameDi", Namespace = "https://erju.org/infra")]
		public List<TrackEdgeRef> preferredSameDir;
		[XmlArrayItem("preferredOppositeDi", Namespace = "https://erju.org/infra")]
		public List<TrackEdgeRef> preferredOppositeDir;

	}
}
