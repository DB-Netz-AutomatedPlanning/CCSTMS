using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "balisePacket")]
	public class BalisePacket
	{
		[XmlAttribute]
		public uint nid;
		[XmlAttribute]
		public QDir q_dir;
				public Packet packet;

	}
}
