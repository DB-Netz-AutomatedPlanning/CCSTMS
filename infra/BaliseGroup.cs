using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "baliseGroup")]
	public class BaliseGroup
	{
		[XmlArrayItem("balis", Namespace = "https://erju.org/infra")]
		public List<infra.Balise> balises;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public uint nidBG {get;set;}
		[XmlAttribute]
		public uint nidC {get;set;}
		[XmlAttribute]
		public infra.BaliseGroupFunction bgFunction {get;set;}
		[XmlAttribute]
		public uint locationAccuracy {get;set;}
	}
}