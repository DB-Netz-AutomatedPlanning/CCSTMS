using System.Xml.Serialization;
using System.Collections.Generic;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "engArea")]
	public class EngArea
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
		[XmlAttribute]
		public SleepersType defaultSleelersType;
		[XmlArrayItem("simplePoint", Namespace = "https://erju.org/eng")]
		public List<SimplePoint> simplePoints;
		[XmlArrayItem("crossing", Namespace = "https://erju.org/eng")]
		public List<Crossing> crossings;
		[XmlArrayItem("levelCrossing", Namespace = "https://erju.org/eng")]
		public List<LevelCrossing> levelCrossings;
		[XmlArrayItem("baliseGroupItem", Namespace = "https://erju.org/eng")]
		public List<BaliseGroup> baliseGroup;
		[XmlArrayItem("balis", Namespace = "https://erju.org/eng")]
		public List<Balise> balises;
		[XmlArrayItem("sleeper", Namespace = "https://erju.org/eng")]
		public List<Sleepers> sleepers;
		[XmlArrayItem("dangerPoint", Namespace = "https://erju.org/eng")]
		public List<DangerPoint> dangerPoints;
		[XmlArrayItem("bufferStop", Namespace = "https://erju.org/eng")]
		public List<BufferStop> bufferStops;
		[XmlArrayItem("mileageArea", Namespace = "https://erju.org/eng")]
		public List<MileageArea> mileageAreas;

	}
}
