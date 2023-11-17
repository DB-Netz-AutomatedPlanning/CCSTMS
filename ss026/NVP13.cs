using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "nVP13")]
	public class NVP13
	{
		[XmlAttribute]
		public uint a_nvp12 {get;set;}
		[XmlAttribute]
		public uint a_nvp23 {get;set;}
	}
}