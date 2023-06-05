using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "engArea")]
	public struct EngArea
	{		
		[XmlAttribute]
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
                return this.id != null ? this.id : "";   
            }
        
        }		
		[XmlArrayItem("propertiesArea", Namespace = "https://erju.org/eng")]
		public List<PropertiesArea> PropertiesArea;		
		[XmlArrayItem("trackCondition", Namespace = "https://erju.org/eng")]
		public List<TrackCondition> trackCondition;		
		[XmlArrayItem("simplePoint", Namespace = "https://erju.org/eng")]
		public List<SimplePoint> simplePoint;		
		[XmlArrayItem("crossing", Namespace = "https://erju.org/eng")]
		public List<Crossing> crossing;		
		[XmlArrayItem("derailer", Namespace = "https://erju.org/eng")]
		public List<Derailer> derailer;		
		[XmlArrayItem("levelCrossing", Namespace = "https://erju.org/eng")]
		public List<LevelCrossing> levelCrossing;		
		[XmlArrayItem("landMark", Namespace = "https://erju.org/eng")]
		public List<LandMark> landMark;		
		[XmlArrayItem("mpTargetMarker", Namespace = "https://erju.org/eng")]
		public List<MpTargetMarker> mpTargetMarker;		
		[XmlArrayItem("stopLocation", Namespace = "https://erju.org/eng")]
		public List<StopLocation> stopLocation;		
		[XmlArrayItem("lightSignal", Namespace = "https://erju.org/eng")]
		public List<LightSignal> lightSignal;		
		[XmlArrayItem("eTCSmarker", Namespace = "https://erju.org/eng")]
		public List<ETCSmarker> eTCSmarker;		
		[XmlArrayItem("balise", Namespace = "https://erju.org/eng")]
		public List<Balise> balise;		
		[XmlArrayItem("baliseGroup", Namespace = "https://erju.org/eng")]
		public List<BaliseGroup> baliseGroup;		
		[XmlArrayItem("tunnel", Namespace = "https://erju.org/eng")]
		public List<Tunnel> tunnel;		
		[XmlArrayItem("bridge", Namespace = "https://erju.org/eng")]
		public List<Bridge> bridge;		
		[XmlArrayItem("culvert", Namespace = "https://erju.org/eng")]
		public List<Culvert> culvert;		
		[XmlArrayItem("mileageChange", Namespace = "https://erju.org/eng")]
		public List<MileageChange> mileageChange;		
		[XmlArrayItem("trackBed", Namespace = "https://erju.org/eng")]
		public List<TrackBed> trackBed;		
		[XmlArrayItem("trackType", Namespace = "https://erju.org/eng")]
		public List<TrackType> trackType;		
		[XmlArrayItem("sleepers", Namespace = "https://erju.org/eng")]
		public List<Sleepers> sleepers;		
		[XmlArrayItem("eTCS", Namespace = "https://erju.org/eng")]
		public List<ETCS> eTCS;		
		[XmlArrayItem("underPass", Namespace = "https://erju.org/eng")]
		public List<UnderPass> underPass;		
		[XmlArrayItem("markerBoard", Namespace = "https://erju.org/eng")]
		public List<MarkerBoard> markerBoard;		
		[XmlArrayItem("nationalBorder", Namespace = "https://erju.org/eng")]
		public List<NationalBorder> nationalBorder;		
		[XmlArrayItem("route", Namespace = "https://erju.org/eng")]
		public List<Route> route;		
		[XmlArrayItem("currentLimitation", Namespace = "https://erju.org/eng")]
		public List<CurrentLimitation> currentLimitation;		
		[XmlArrayItem("permittedBrakingDistance", Namespace = "https://erju.org/eng")]
		public List<PermittedBrakingDistance> permittedBrakingDistance;		
		[XmlArrayItem("genericLinearObject", Namespace = "https://erju.org/eng")]
		public List<GenericLinearObject> genericLinearObject;		
		[XmlArrayItem("dangerPoint", Namespace = "https://erju.org/eng")]
		public List<DangerPoint> dangerPoint;
	}
}