using System.Xml.Serialization;
using System.Collections.Generic;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "engArea")]
	public class EngArea
	{
		[XmlArrayItem("simplePoint", Namespace = "https://erju.org/eng")]
		public List<eng.SimplePoint> simplePoints;
		[XmlArrayItem("crossing", Namespace = "https://erju.org/eng")]
		public List<eng.Crossing> crossings;
		[XmlArrayItem("levelCrossing", Namespace = "https://erju.org/eng")]
		public List<eng.LevelCrossing> levelCrossings;
		[XmlArrayItem("baliseGroupItem", Namespace = "https://erju.org/eng")]
		public List<eng.BaliseGroup> baliseGroup;
		[XmlArrayItem("balis", Namespace = "https://erju.org/eng")]
		public List<eng.Balise> balises;
		[XmlArrayItem("sleeper", Namespace = "https://erju.org/eng")]
		public List<eng.Sleepers> sleepers;
		[XmlArrayItem("dangerPoint", Namespace = "https://erju.org/eng")]
		public List<eng.DangerPoint> dangerPoints;
		[XmlArrayItem("bufferStop", Namespace = "https://erju.org/eng")]
		public List<eng.BufferStop> bufferStops;
		[XmlArrayItem("mileageArea", Namespace = "https://erju.org/eng")]
		public List<eng.MileageArea> mileageAreas;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public eng.SleepersType defaultSleelersType {get;set;}
	}
}