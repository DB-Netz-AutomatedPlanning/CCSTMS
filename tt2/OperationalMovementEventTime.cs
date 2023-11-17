using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/tt2", ElementName = "operationalMovementEventTime")]
	public class OperationalMovementEventTime
	{
		[XmlAttribute]
		public tt2.MovementEventTimeType type {get;set;}
		[XmlAttribute]
		public string dateTime {get;set;}
	}
}