using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "lMKVR")]
	public class LMKVR
	{
		[XmlAttribute]
		public uint l_nvkrint_l {get;set;}
		[XmlAttribute]
		public uint m_nvkrint_l {get;set;}
	}
}