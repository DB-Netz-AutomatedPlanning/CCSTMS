using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/tt2", ElementName = "operationalTrainUnit")]
	public class OperationalTrainUnit
	{
		public tt2.PhysicalTrainUnitIdentifier? physicalTrainUnit {get;set;}
		public tt2.OperationalTrainCategory? operationalTrainCategory {get;set;}
		[XmlArrayItem("operationalConsist", Namespace = "https://erju.org/tt2")]
		public List<tt2.OperationalConsist> operationalConsists;
		[XmlAttribute]
		public uint nominalRotatingMass {get;set;}
		[XmlAttribute]
		public uint regularBrakeWeightPercentage {get;set;}
		[XmlAttribute]
		public uint emergencyBrakeWeightPercentage {get;set;}
		[XmlAttribute]
		public tt2.BrakePosition brakePosition {get;set;}
		[XmlAttribute]
		public tt2.BrakeModelType brakeModelType {get;set;}
		[XmlAttribute]
		public tt2.GradeOfAutomation usedGradeOfAutomation {get;set;}
	}
}