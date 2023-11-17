using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_5")]
	public class ETCSPacket_5
	{
		[XmlArrayItem("link", Namespace = "https://erju.org/ss026")]
		public List<ss026.LinkItem> links;
	}
}