using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_44")]
	public class ETCSPacket_44
	{
		[XmlAttribute]
		public uint nid_xuser {get;set;}
		[XmlAttribute]
		public uint nid_ntc {get;set;}
		[XmlAttribute]
		public string otherData {get;set;}
	}
}