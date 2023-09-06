using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_79")]
	public class ETCSPacket_79
	{
		[XmlArrayItem("geoPosItem", Namespace = "https://erju.org/ss026")]
		public List<GeoPosItem> geoPosItems;

	}
}
