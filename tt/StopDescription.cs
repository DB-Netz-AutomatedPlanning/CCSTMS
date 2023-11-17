using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "stopDescription")]
	public class StopDescription
	{
		public tt.StopTimes? stopTimes {get;set;}
		[XmlArrayItem("stopActivity", Namespace = "https://erju.org/tt")]
		public List<tt.StopActivity> stopActivities;
		[XmlArrayItem("platformEdge", Namespace = "https://erju.org/tt")]
		public List<PlatformEdgeRef> platformEdges;
		[XmlAttribute]
		public tt.StopType stopType {get;set;}
		[XmlAttribute]
		public bool stopOnDemand {get;set;}
		[XmlAttribute]
		public bool stopSkipped {get;set;}
		[XmlAttribute]
		public tt.LoadingDirection onOff {get;set;}
		[XmlAttribute]
		public tt.DoorSide openingDoorSide {get;set;}
		[XmlAttribute]
		public bool centralisedOpening {get;set;}
		[XmlAttribute]
		public bool centralisedClosing {get;set;}
		[XmlAttribute]
		public bool changeOfGradeOfAutomation {get;set;}
		[XmlAttribute]
		public bool relaxedCoupler {get;set;}
		[XmlAttribute]
		public bool holdTrain {get;set;}
	}
}