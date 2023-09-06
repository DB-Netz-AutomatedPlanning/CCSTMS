using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "vMM")]
	public class VMM
	{		
		[XmlAttribute]
		public uint v_nvkvint_k_m;		
		[XmlAttribute]
		public uint m_nvkvint_k_m;		
		[XmlAttribute]
		public uint m_nvkvint_k_m_2;
}