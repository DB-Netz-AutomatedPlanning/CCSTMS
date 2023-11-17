using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "operationalEventTime")]
	public class OperationalEventTime
	{
		[XmlAttribute]
		public tt.EventTimeType type {get;set;}
		[XmlAttribute]
		public string dateTime {get;set;}
	}
}