using System.Xml.Serialization;
using System.Collections.Generic;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "balise")]
	public class Balise
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
		[XmlAttribute(AttributeName ="fixed")]
		public bool _fixed;
		[XmlAttribute]
		public bool q_updown;
		[XmlAttribute]
		public DuplicationType m_dup;
		[XmlAttribute]
		public uint m_mcount;
		[XmlAttribute]
		public bool verticallyOriented;
		[XmlAttribute]
		public bool standardSize;
		[XmlArrayItem("etcsPacket", Namespace = "https://erju.org/eng")]
		public List<ss026.BalisePacket> etcsPackets;

	}
}
