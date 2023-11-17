using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_132")]
	public class ETCSPacket_132
	{
		[XmlAttribute]
		public bool q_aspect {get;set;}
	}
}