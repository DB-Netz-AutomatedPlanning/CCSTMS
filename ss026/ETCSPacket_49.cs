using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_49")]
	public class ETCSPacket_49
	{
		[XmlArrayItem("balis", Namespace = "https://erju.org/ss026")]
		public List<ss026.CountryBalise> balises;
	}
}