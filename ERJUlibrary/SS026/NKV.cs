using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "nKV")]
	public class NKV
	{		
		[XmlAttribute]
		public bool q_nvkint;		 
		[XmlAttribute]
		public KVType q_nvkvintset;		
		[XmlAttribute]
		public uint a_nvp12;		
		[XmlAttribute]
		public uint a_nvp23;		
		[XmlAttribute]
		public uint v_nvkvint;		
		[XmlAttribute]
		public double m_nvkvint;		
		[XmlAttribute]
		public uint m_nvkvint_2;		
		[XmlArrayItem("nKVItem", Namespace = "https://erju.org/")]
		public List<NKVItem>? items;		
		[XmlArrayItem("nKVSubItem", Namespace = "https://erju.org/")]
		public List<NKVSubItem>? qvItem;		
		[XmlArrayItem("lMKVR", Namespace = "https://erju.org/")]
		public List<LMKVR>? lmkvrs;		
		[XmlAttribute]
		public uint m_nvkrint;
}