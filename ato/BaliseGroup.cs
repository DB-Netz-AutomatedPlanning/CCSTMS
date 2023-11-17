using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "baliseGroup")]
	public class BaliseGroup
	{
		[XmlArrayItem("balis", Namespace = "https://erju.org/ato")]
		public List<ato.Balise> balises;
		[XmlAttribute]
		public uint nidBG {get;set;}
		[XmlAttribute]
		public bool nidCQualifier {get;set;}
		[XmlAttribute]
		public uint nidC {get;set;}
	}
}