using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "operationalTrainUnit")]
	public class OperationalTrainUnit
	{
		public tt.PhysicalTrainUnitIdentifier? physicalTrainUnit {get;set;}
		public tt.OperationalTrainCategory? operationalTrainCategory {get;set;}
		[XmlArrayItem("operationalConsistRef", Namespace = "https://erju.org/tt")]
		public List<OperationalConsistRefRef> operationalConsistRefs;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string uuid {get;set;}
		[XmlAttribute]
		public uint nominalRotatingMass {get;set;}
		[XmlAttribute]
		public uint regularBrakeWeightPercentage {get;set;}
		[XmlAttribute]
		public uint emergencyBrakeWeightPercentage {get;set;}
		[XmlAttribute]
		public tt.BrakePosition brakePosition {get;set;}
		[XmlAttribute]
		public tt.BrakeModelType brakeModelType {get;set;}
		[XmlAttribute]
		public tt.GradeOfAutomation usedGradeOfAutomation {get;set;}
	}
}