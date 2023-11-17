using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_40")]
	public class ETCSPacket_40
	{
		[XmlAttribute]
		public uint d_current {get;set;}
		[XmlAttribute]
		public uint m_current {get;set;}
	}
}