using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_88")]
	public class ETCSPacket_88
	{
		public ss026.LXStatus? lxStatus {get;set;}
		[XmlAttribute]
		public uint nid_lx {get;set;}
		[XmlAttribute]
		public uint d_lx {get;set;}
		[XmlAttribute]
		public uint l_lx {get;set;}
	}
}