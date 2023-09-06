using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "propertiesArea")]
	public class PropertiesArea
	{		
		[XmlAttribute]
		private string? areaId;
		[XmlAttribute(AttributeName = "areaId")]
		public string AreaId
        {
            set
            {
                this.areaId = value;
            }
            get
            {
                return this.areaId != null ? this.areaId : "";   
            }
        
        }		
		[XmlAttribute]
		public uint gauge;
        [XmlAttribute]
        public LoadingGaugeType loadingGaugeType;
        [XmlArrayItem("trackEdgeGauge", Namespace = "https://erju.org/infra")]
        public List<TrackEdgeGauge>? trackEdgeGauges;
        [XmlArrayItem("trackEdgeLoadingGauge", Namespace = "https://erju.org/infra")]
        public List<TrackEdgeLoadingGauge>? trackEdgeLoadingGauges;
        [XmlArrayItem("trackCondition", Namespace = "https://erju.org/infra")]
        public List<TrackCondition>? trackConditions;
        [XmlArrayItem("secondaryTrack", Namespace = "https://erju.org/infra")]
        public List<SecondaryTrackRef>? secondaryTracks;
        [XmlArrayItem("shuntingTrack", Namespace = "https://erju.org/infra")]
        public List<ShuntingTrackRef>? shuntingTracks;
        [XmlArrayItem("permittedBrakingDistance", Namespace = "https://erju.org/infra")]
        public List<PermittedBrakingDistance>? permittedBrakingDistances;
        [XmlArrayItem("currentLimitation", Namespace = "https://erju.org/infra")]
        public List<CurrentLimitation>? currentLimitations;
    }
}