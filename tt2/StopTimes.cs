using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/tt2", ElementName = "stopTimes")]
	public class StopTimes
	{
		[XmlAttribute]
		public uint minStopTime {get;set;}
		[XmlAttribute]
		public uint operationalReserve {get;set;}
		[XmlAttribute]
		public uint additionalReserve {get;set;}
	}
}