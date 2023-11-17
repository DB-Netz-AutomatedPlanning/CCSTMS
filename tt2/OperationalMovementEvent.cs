using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/tt2", ElementName = "operationalMovementEvent")]
	public class OperationalMovementEvent
	{
		//public infra.DirTrackEdgePoint? position {get;set;}
		[XmlArrayItem("operationalEventTime", Namespace = "https://erju.org/tt2")]
		public List<tt2.OperationalMovementEventTime> operationalEventTimes;
		[XmlArrayItem("blockingEvent", Namespace = "https://erju.org/tt2")]
		public List<tt2.OperationalEventRef> blockingEvents;
		public infra.LinkedPath? trackPathToSubsequentEvent {get;set;}
		public tt2.StopDescription? stopDescription {get;set;}
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public tt2.EventType type {get;set;}
		[XmlAttribute]
		public tt2.AlignmentType alignment {get;set;}
	}
}