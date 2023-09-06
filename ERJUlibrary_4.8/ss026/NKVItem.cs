using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "nKVItem")]
	public class NKVItem
	{
		[XmlAttribute]
		public uint v_nvkvint;
		[XmlAttribute]
		public uint m_nvkvint;

	}
}
