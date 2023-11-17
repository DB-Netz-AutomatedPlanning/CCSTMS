using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "vMM")]
	public class VMM
	{
		[XmlAttribute]
		public uint v_nvkvint_k_m {get;set;}
		[XmlAttribute]
		public uint m_nvkvint_k_m {get;set;}
		[XmlAttribute]
		public uint m_nvkvint_k_m_2 {get;set;}
	}
}