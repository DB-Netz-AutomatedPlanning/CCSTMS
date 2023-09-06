using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "lXStatus")]
	public class LXStatus
	{
		[XmlAttribute]
		public uint v_lx;
		[XmlAttribute]
		public bool q_stoplx;
		[XmlAttribute]
		public uint l_stoplx;

	}
}
