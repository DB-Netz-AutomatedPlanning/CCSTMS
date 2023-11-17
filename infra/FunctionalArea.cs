using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "functionalArea")]
	public class FunctionalArea
	{
		[XmlArrayItem("opPoint", Namespace = "https://erju.org/infra")]
		public List<infra.OperationalPoint> opPoints;
		[XmlArrayItem("timingPoint", Namespace = "https://erju.org/infra")]
		public List<infra.TimingPoint> timingPoints;
		[XmlArrayItem("simplePoint", Namespace = "https://erju.org/infra")]
		public List<infra.SimplePoint> simplePoints;
		[XmlArrayItem("slipCrossing", Namespace = "https://erju.org/infra")]
		public List<infra.SlipCrossing> slipCrossings;
		[XmlArrayItem("derailer", Namespace = "https://erju.org/infra")]
		public List<infra.Derailer> derailers;
		[XmlArrayItem("crossing", Namespace = "https://erju.org/infra")]
		public List<infra.Crossing> crossings;
		[XmlArrayItem("trainDetector", Namespace = "https://erju.org/infra")]
		public List<infra.TrainDetector> trainDetectors;
		[XmlArrayItem("baliseGroup", Namespace = "https://erju.org/infra")]
		public List<infra.BaliseGroup> baliseGroups;
		[XmlArrayItem("etcsMarker", Namespace = "https://erju.org/infra")]
		public List<infra.ETCSMarker> etcsMarkers;
		[XmlArrayItem("stopLocation", Namespace = "https://erju.org/infra")]
		public List<infra.StopLocation> stopLocations;
		[XmlArrayItem("teSpeedProfile", Namespace = "https://erju.org/infra")]
		public List<infra.TrackEdgeSpeedProfile> teSpeedProfiles;
		[XmlArrayItem("tunnel", Namespace = "https://erju.org/infra")]
		public List<infra.Tunnel> tunnels;
		[XmlArrayItem("bridge", Namespace = "https://erju.org/infra")]
		public List<infra.Bridge> bridges;
		[XmlArrayItem("underpass", Namespace = "https://erju.org/infra")]
		public List<infra.Underpass> underpasses;
		[XmlArrayItem("tvp", Namespace = "https://erju.org/infra")]
		public List<infra.TvpSection> tvps;
		[XmlArrayItem("levelCrossing", Namespace = "https://erju.org/infra")]
		public List<infra.LevelCrossing> levelCrossings;
		[XmlArrayItem("nationalBorder", Namespace = "https://erju.org/infra")]
		public List<infra.NationalBorder> nationalBorders;
		[XmlArrayItem("bufferStop", Namespace = "https://erju.org/infra")]
		public List<infra.BufferStop> bufferStops;
		[XmlAttribute]
		public string id {get;set;}
	}
}