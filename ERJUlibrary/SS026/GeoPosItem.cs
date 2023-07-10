using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "geoPosItem")]
	public class GeoPosItem
	{		
		public NewCountry? newCountry;		
		[XmlAttribute]
		public uint nid_bg;		
		[XmlAttribute]
		public uint d_posoff;		
		[XmlAttribute]
		public bool q_mposition;		
		[XmlAttribute]
		public uint m_position;
}