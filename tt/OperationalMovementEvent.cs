using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "operationalMovementEvent")]
	public class OperationalMovementEvent
	{
		public tt.OperationalMovementEventPosition? position {get;set;}
		[XmlArrayItem("operationalEventTime", Namespace = "https://erju.org/tt")]
		public List<tt.OperationalEventTime> operationalEventTimes;
		[XmlArrayItem("operationalEventLink", Namespace = "https://erju.org/tt")]
		public List<tt.OperationalEventLink> operationalEventLinks;
		public infra.LinkedPath? trackPathToSubsequentEvent {get;set;}
		public tt.StopDescription? stopDescription {get;set;}
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public tt.EventType type {get;set;}
		[XmlAttribute]
		public tt.AlignmentType alignment {get;set;}
		[XmlAttribute]
		public bool changedSincePreviousVersion {get;set;}
	}
}