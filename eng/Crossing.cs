using System.Xml.Serialization;
using System.Collections.Generic;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "crossing")]
	public class Crossing
	{
		[XmlArrayItem("dangerPoint", Namespace = "https://erju.org/eng")]
		public List<DangerPointRef> dangerPoints;
		[XmlAttribute]
		public string id {get;set;}
	}
}