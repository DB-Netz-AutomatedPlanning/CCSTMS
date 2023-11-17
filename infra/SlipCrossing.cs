using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "slipCrossing")]
	public class SlipCrossing
	{
		[XmlArrayItem("simplePoint", Namespace = "https://erju.org/infra")]
		public List<SimplePointRef> simplePoints;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string crossing {get;set;}
	}
}