using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "functionalArea")]
	public class FunctionalArea
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
		[XmlArrayItem("opPoint", Namespace = "https://erju.org/infra")]
		public List<OperationalPoint> opPoints;
		[XmlArrayItem("timingPoint", Namespace = "https://erju.org/infra")]
		public List<TimingPoint> timingPoints;
		[XmlArrayItem("simplePoint", Namespace = "https://erju.org/infra")]
		public List<SimplePoint> simplePoints;
		[XmlArrayItem("slipCrossing", Namespace = "https://erju.org/infra")]
		public List<SlipCrossing> slipCrossings;
		[XmlArrayItem("derailer", Namespace = "https://erju.org/infra")]
		public List<Derailer> derailers;
		[XmlArrayItem("crossing", Namespace = "https://erju.org/infra")]
		public List<Crossing> crossings;
		[XmlArrayItem("switchedCrossing", Namespace = "https://erju.org/infra")]
		public List<SwitchedCrossing> switchedCrossings;
		[XmlArrayItem("trainDetector", Namespace = "https://erju.org/infra")]
		public List<TrainDetector> trainDetectors;
		[XmlArrayItem("baliseGroup", Namespace = "https://erju.org/infra")]
		public List<BaliseGroup> baliseGroups;
		[XmlArrayItem("etcsMarker", Namespace = "https://erju.org/infra")]
		public List<ETCSMarker> etcsMarkers;
		[XmlArrayItem("stopLocation", Namespace = "https://erju.org/infra")]
		public List<StopLocation> stopLocations;
		[XmlArrayItem("teSpeedProfile", Namespace = "https://erju.org/infra")]
		public List<TrackEdgeSpeedProfile> teSpeedProfiles;
		[XmlArrayItem("tunnel", Namespace = "https://erju.org/infra")]
		public List<Tunnel> tunnels;
		[XmlArrayItem("bridge", Namespace = "https://erju.org/infra")]
		public List<Bridge> bridges;
		[XmlArrayItem("underpass", Namespace = "https://erju.org/infra")]
		public List<Underpass> underpasses;
		[XmlArrayItem("tvp", Namespace = "https://erju.org/infra")]
		public List<TvpSection> tvps;
		[XmlArrayItem("levelCrossing", Namespace = "https://erju.org/infra")]
		public List<LevelCrossing> levelCrossings;
		[XmlArrayItem("nationalBorder", Namespace = "https://erju.org/infra")]
		public List<NationalBorder> nationalBorders;
		[XmlArrayItem("bufferStop", Namespace = "https://erju.org/infra")]
		public List<BufferStop> bufferStops;

	}
}
