using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/tt2", ElementName = "operationalPlanOperationalMovement")]
	public class OperationalPlanOperationalMovement
	{
		[XmlArrayItem("operationalTrainUnit", Namespace = "https://erju.org/tt2")]
		public List<tt2.OperationalTrainUnit> operationalTrainUnits;
		[XmlArrayItem("operationalMovementEvent", Namespace = "https://erju.org/tt2")]
		public List<tt2.OperationalMovementEvent> operationalMovementEvents;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string versionId {get;set;}
		[XmlAttribute]
		public string mapDataVersionRef {get;set;}
	}
}