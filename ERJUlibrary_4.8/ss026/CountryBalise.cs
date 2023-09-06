using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "countryBalise")]
	public class CountryBalise
	{
		[XmlAttribute]
		public bool q_newcountry_k;
		[XmlAttribute]
		public uint nid_c_k;
		[XmlAttribute]
		public uint nid_bg_k;

	}
}
