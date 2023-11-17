using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "stopTimes")]
	public class StopTimes
	{
		[XmlAttribute]
		public uint minimalTime {get;set;}
		[XmlAttribute]
		public uint operationalReserve {get;set;}
		[XmlAttribute]
		public uint additionalReserve {get;set;}
	}
}