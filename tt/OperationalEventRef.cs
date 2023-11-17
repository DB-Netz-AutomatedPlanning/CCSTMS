using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "operationalEventRef")]
	public class OperationalEventRef
	{
		[XmlAttribute]
		public string movementEvent {get;set;}
		[XmlAttribute]
		public string restrictionEvent {get;set;}
		[XmlAttribute]
		public string warningMeasureEvent {get;set;}
	}
}