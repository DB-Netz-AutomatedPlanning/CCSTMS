using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_65")]
	public class ETCSPacket_65
	{
		[XmlAttribute]
		public uint nid_tsr {get;set;}
		[XmlAttribute]
		public uint d_tsr {get;set;}
		[XmlAttribute]
		public uint l_tsr {get;set;}
		[XmlAttribute]
		public bool q_front {get;set;}
		[XmlAttribute]
		public uint v_tsr {get;set;}
	}
}