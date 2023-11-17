using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "currentChange")]
	public class CurrentChange
	{
		[XmlAttribute]
		public uint pos {get;set;}
		[XmlAttribute]
		public uint current {get;set;}
	}
}