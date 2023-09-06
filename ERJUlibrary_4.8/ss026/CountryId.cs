using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "countryId")]
	public class CountryId
	{
		[XmlAttribute]
		public uint nid_c;

	}
}
