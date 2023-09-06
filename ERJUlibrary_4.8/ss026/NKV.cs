using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "nKV")]
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
		[XmlArrayItem("item", Namespace = "https://erju.org/ss026")]
		public List<NKVItem> items;
		[XmlArrayItem("qvItemItem", Namespace = "https://erju.org/ss026")]
		public List<NKVSubItem> qvItem;
		[XmlArrayItem("lmkvr", Namespace = "https://erju.org/ss026")]
		public List<LMKVR> lmkvrs;
		[XmlAttribute]
		public uint m_nvkrint;

	}
}
