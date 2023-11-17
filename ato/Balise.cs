using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "balise")]
	public class Balise
	{
		[XmlAttribute]
		public uint positionInGroup {get;set;}
		[XmlAttribute]
		public uint pos {get;set;}
	}
}