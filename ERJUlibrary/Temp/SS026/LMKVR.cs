using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "lMKVR")]
	public class LMKVR
	{		
		[XmlAttribute]
		public uint l_nvkrint_l;		
		[XmlAttribute]
		public uint m_nvkrint_l;
}