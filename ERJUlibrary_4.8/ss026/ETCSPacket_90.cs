using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_90")]
	public class ETCSPacket_90
	{
		public NewCountry newCountry;
		[XmlAttribute]
		public uint nid_bg;

	}
}
