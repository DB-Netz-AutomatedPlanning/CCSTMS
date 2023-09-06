using System.Xml.Serialization;
using System.Collections.Generic;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "baliseGroup")]
	public class BaliseGroup
	{
		private string id;
		[XmlAttribute(AttributeName = "id")]
		public string Id
		{
			set
			{
				this.id = value;
			}
			get
			{
				return this.id != null?  this.id : "";
			}
}
		[XmlAttribute]
		public ss026.ETCSVersion m_version;
		[XmlAttribute]
		public bool q_link;

	}
}
