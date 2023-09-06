using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_136")]
	public class ETCSPacket_136
	{
		public NewCountry newCountry;
		[XmlAttribute]
		public uint nid_bg;

	}
}
