using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_136")]
	public class ETCSPacket_136
	{
		public ss026.NewCountry? newCountry {get;set;}
		[XmlAttribute]
		public uint nid_bg {get;set;}
	}
}