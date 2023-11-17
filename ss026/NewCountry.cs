using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "newCountry")]
	public class NewCountry
	{
		[XmlAttribute]
		public uint nid_c {get;set;}
	}
}