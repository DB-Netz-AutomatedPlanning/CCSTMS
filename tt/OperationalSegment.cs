using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "operationalSegment")]
	public class OperationalSegment
	{
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string uuid {get;set;}
		[XmlAttribute]
		public uint sequence {get;set;}
		[XmlAttribute]
		public string operationalTrainUnitRef {get;set;}
	}
}