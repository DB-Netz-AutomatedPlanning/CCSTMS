using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "baliseGroup")]
	public class BaliseGroup
	{		
		[XmlAttribute]
		public uint nidBG;		
		[XmlArrayItem("balise", Namespace = "https://erju.org/ato")]
		public List<Balise>? balises;		
		[XmlAttribute]
		public bool nidCQualifier;		
		[XmlAttribute]
		public uint nidC;
	}
}