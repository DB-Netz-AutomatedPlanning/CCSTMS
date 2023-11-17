using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_0")]
	public class ETCSPacket_0
	{
		[XmlAttribute]
		public uint nid_vbcmk {get;set;}
	}
}