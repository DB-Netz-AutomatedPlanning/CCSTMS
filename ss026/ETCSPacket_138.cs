using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_138")]
	public class ETCSPacket_138
	{
		[XmlAttribute]
		public uint d_startreverse {get;set;}
		[XmlAttribute]
		public uint l_reversearea {get;set;}
	}
}