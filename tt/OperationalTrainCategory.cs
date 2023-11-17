using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "operationalTrainCategory")]
	public class OperationalTrainCategory
	{
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string uuid {get;set;}
		[XmlAttribute]
		public tt.TrainCategoryType name {get;set;}
		[XmlAttribute]
		public string description {get;set;}
		[XmlAttribute]
		public tt.TrainUsageType trainUsage {get;set;}
	}
}