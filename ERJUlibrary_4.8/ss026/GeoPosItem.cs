using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "geoPosItem")]
	public class GeoPosItem
	{
		public NewCountry newCountry;
		[XmlAttribute]
		public uint nid_bg;
		[XmlAttribute]
		public uint d_posoff;
		[XmlAttribute]
		public bool q_mposition;
		[XmlAttribute]
		public uint m_position;

	}
}
