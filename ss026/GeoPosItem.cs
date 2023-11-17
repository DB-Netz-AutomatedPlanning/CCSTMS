using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "geoPosItem")]
	public class GeoPosItem
	{
		public ss026.NewCountry? newCountry {get;set;}
		[XmlAttribute]
		public uint nid_bg {get;set;}
		[XmlAttribute]
		public uint d_posoff {get;set;}
		[XmlAttribute]
		public bool q_mposition {get;set;}
		[XmlAttribute]
		public uint m_position {get;set;}
	}
}