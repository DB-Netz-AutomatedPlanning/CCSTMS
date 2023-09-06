using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "baliseGroup")]
	public class BaliseGroup
	{		
		[XmlAttribute]
		public uint nidBG;		
		[XmlArrayItem("balise", Namespace = "https://erju.org/ato")]
		public List<Balise> balises;		
		[XmlAttribute]
		public bool nidCQualifier;		
		[XmlAttribute]
		public uint nidC;
	}
}
