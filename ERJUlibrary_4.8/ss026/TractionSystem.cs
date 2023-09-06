using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "tractionSystem")]
	public class TractionSystem
	{
		[XmlAttribute]
		public VoltageType d_voltage;
		[XmlAttribute]
		public uint nid_ctraction;

	}
}
