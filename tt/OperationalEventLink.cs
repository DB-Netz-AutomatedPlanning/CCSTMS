using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "operationalEventLink")]
	public class OperationalEventLink
	{
		public tt.OperationalEventRef? operationalEvent {get;set;}
		[XmlAttribute]
		public tt.EventType type {get;set;}
	}
}