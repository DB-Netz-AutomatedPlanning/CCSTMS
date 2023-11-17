using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "timingPointMapping")]
	public class TimingPointMapping
	{
		[XmlAttribute]
		public string infraTimingPoint {get;set;}
		[XmlAttribute]
		public string atoTimingPoint {get;set;}
	}
}