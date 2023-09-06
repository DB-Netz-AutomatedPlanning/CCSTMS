using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_16")]
	public class ETCSPacket_16
	{
		[XmlAttribute]
		public uint l_section;

	}
}
