using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "operationalPlanOperationalMovement")]
	public class OperationalPlanOperationalMovement
	{
		[XmlArrayItem("operationalSegment", Namespace = "https://erju.org/tt")]
		public List<tt.OperationalSegment> operationalSegments;
		[XmlArrayItem("operationalTrainUnit", Namespace = "https://erju.org/tt")]
		public List<tt.OperationalTrainUnit> operationalTrainUnits;
		[XmlArrayItem("operationalConsist", Namespace = "https://erju.org/tt")]
		public List<tt.OperationalConsist> operationalConsists;
		[XmlArrayItem("operationalMovementEvent", Namespace = "https://erju.org/tt")]
		public List<tt.OperationalMovementEvent> operationalMovementEvents;
		[XmlArrayItem("operationalMovementMarker", Namespace = "https://erju.org/tt")]
		public List<tt.OperationalMovementMarker> operationalMovementMarkers;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string uuid {get;set;}
		[XmlAttribute]
		public string versionId {get;set;}
		[XmlAttribute]
		public string mapDataVersionRef {get;set;}
	}
}