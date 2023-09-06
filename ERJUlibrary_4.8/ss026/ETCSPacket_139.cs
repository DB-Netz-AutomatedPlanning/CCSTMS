using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_139")]
	public class ETCSPacket_139
	{
		[XmlAttribute]
		public uint d_reverse;
		[XmlAttribute]
		public uint v_reverse;

	}
}
