using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "slopeSamplePoint")]
	public class SlopeSamplePoint
	{
		[XmlAttribute]
		public uint pos;
		[XmlAttribute]
		public int slope;

	}
}
