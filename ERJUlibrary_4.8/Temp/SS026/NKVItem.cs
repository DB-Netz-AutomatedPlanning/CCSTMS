using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "nKVItem")]
	public class NKVItem
	{		
		[XmlAttribute]
		public uint v_nvkvint;
		[XmlAttribute]
		public uint m_nvkvint;
}