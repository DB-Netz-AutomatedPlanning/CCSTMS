using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "routeSuitability")]
	public class RouteSuitability
	{
		[XmlAttribute]
		public uint loadingGauge;
		[XmlAttribute]
		public uint maxAxleLoad;
		public TractionSystem voltage;

	}
}
