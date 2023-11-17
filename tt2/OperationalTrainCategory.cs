using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/tt2", ElementName = "operationalTrainCategory")]
	public class OperationalTrainCategory
	{
		[XmlAttribute]
		public tt2.TrainCategoryType name {get;set;}
		[XmlAttribute]
		public string description {get;set;}
		[XmlAttribute]
		public tt2.TrainUsageType trainUsage {get;set;}
	}
}