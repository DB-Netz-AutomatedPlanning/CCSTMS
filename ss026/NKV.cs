using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "nKV")]
	public class NKV
	{
		[XmlArrayItem("item", Namespace = "https://erju.org/ss026")]
		public List<ss026.NKVItem> items;
		[XmlArrayItem("qvItemItem", Namespace = "https://erju.org/ss026")]
		public List<ss026.NKVSubItem> qvItem;
		[XmlArrayItem("lmkvr", Namespace = "https://erju.org/ss026")]
		public List<ss026.LMKVR> lmkvrs;
		[XmlAttribute]
		public bool q_nvkint {get;set;}
		[XmlAttribute]
		public ss026.KVType q_nvkvintset {get;set;}
		[XmlAttribute]
		public uint a_nvp12 {get;set;}
		[XmlAttribute]
		public uint a_nvp23 {get;set;}
		[XmlAttribute]
		public uint v_nvkvint {get;set;}
		[XmlAttribute]
		public double m_nvkvint {get;set;}
		[XmlAttribute]
		public uint m_nvkvint_2 {get;set;}
		[XmlAttribute]
		public uint m_nvkrint {get;set;}
	}
}