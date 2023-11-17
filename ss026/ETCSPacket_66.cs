using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_66")]
	public class ETCSPacket_66
	{
		[XmlAttribute]
		public uint nid_tsr {get;set;}
	}
}