using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_180")]
	public class ETCSPacket_180
	{
		[XmlAttribute]
		public bool q_lssma;
		[XmlAttribute]
		public uint t_lssma;

	}
}
