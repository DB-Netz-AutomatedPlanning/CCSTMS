using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/tt2", ElementName = "stopDescription")]
	public class StopDescription
	{
		public tt2.StopTimes? stopTimes {get;set;}
		[XmlArrayItem("trainUnitActivity", Namespace = "https://erju.org/tt2")]
		public List<tt2.TrainUnitActivity> trainUnitActivities;
		[XmlArrayItem("platformEdge", Namespace = "https://erju.org/tt2")]
		public List<PlatformEdgeRef> platformEdges;
		[XmlArrayItem("passengerTransferActivity", Namespace = "https://erju.org/tt2")]
		public List<tt2.PassengerTransferActivity> passengerTransferActivities;
		[XmlAttribute]
		public tt2.StopType stopType {get;set;}
		[XmlAttribute]
		public bool stopOnDemand {get;set;}
		[XmlAttribute]
		public bool stopSkipped {get;set;}
		[XmlAttribute]
		public tt2.LoadingDirection onOff {get;set;}
		[XmlAttribute]
		public tt2.DoorSide openingDoorSide {get;set;}
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