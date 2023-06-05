using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "functionalArea")]
	public struct FunctionalArea
	{		
		[XmlAttribute]
		private string areaId;
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
		[XmlArrayItem("operationalPoint", Namespace = "https://erju.org/topo")]
		public List<OperationalPoint> opPoints;		
		[XmlArrayItem("timingPoint", Namespace = "https://erju.org/topo")]
		public List<TimingPoint> timingPoints;		
		[XmlArrayItem("simplePoint", Namespace = "https://erju.org/topo")]
		public List<SimplePoint> simplePoints;		
		[XmlArrayItem("slipCrossing", Namespace = "https://erju.org/topo")]
		public List<SlipCrossing> slipCrossings;		
		[XmlArrayItem("derailer", Namespace = "https://erju.org/topo")]
		public List<Derailer> derailers;		
		[XmlArrayItem("crossing", Namespace = "https://erju.org/topo")]
		public List<Crossing> crossings;		
		[XmlArrayItem("baliseGroup", Namespace = "https://erju.org/topo")]
		public List<BaliseGroup> baliseGroups;		
		[XmlArrayItem("eTCSMarker", Namespace = "https://erju.org/topo")]
		public List<ETCSMarker> etcsMarkers;		
		[XmlArrayItem("stopLocation", Namespace = "https://erju.org/topo")]
		public List<StopLocation> stopLocations;		
		[XmlArrayItem("trackEdgeSpeedProfile", Namespace = "https://erju.org/topo")]
		public List<TrackEdgeSpeedProfile> teSpeedProfiles;		
		[XmlArrayItem("tunnel", Namespace = "https://erju.org/topo")]
		public List<Tunnel> tunnels;		
		[XmlArrayItem("bridge", Namespace = "https://erju.org/topo")]
		public List<Bridge> bridges;		
		[XmlArrayItem("underpass", Namespace = "https://erju.org/topo")]
		public List<Underpass> underpasses;		
		[XmlArrayItem("tvpSection", Namespace = "https://erju.org/topo")]
		public List<TvpSection> tvps;		
		[XmlArrayItem("mpTargetMarker", Namespace = "https://erju.org/topo")]
		public List<MpTargetMarker> mpTargetMarkers;		
		[XmlArrayItem("levelCrossing", Namespace = "https://erju.org/topo")]
		public List<LevelCrossing> levelCrossings;		
		[XmlArrayItem("border", Namespace = "https://erju.org/topo")]
		public List<Border> borders;
	}
}