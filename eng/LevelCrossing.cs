using System.Xml.Serialization;
using System.Collections.Generic;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "levelCrossing")]
	public class LevelCrossing
	{
		[XmlArrayItem("dangerPoint", Namespace = "https://erju.org/eng")]
		public List<DangerPointRef> dangerPoints;
		[XmlAttribute]
		public string id {get;set;}
	}
}