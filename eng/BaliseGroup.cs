using System.Xml.Serialization;
using System.Collections.Generic;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "baliseGroup")]
	public class BaliseGroup
	{
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public ss026.ETCSVersion m_version {get;set;}
		[XmlAttribute]
		public bool q_link {get;set;}
	}
}