using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "physicalTrainUnitIdentifier")]
	public class PhysicalTrainUnitIdentifier
	{
		[XmlAttribute]
		public string trainRunningNumber {get;set;}
		[XmlAttribute]
		public string additionalTrainRunningNumber {get;set;}
		[XmlAttribute]
		public string tafTapTsiTrainID {get;set;}
		[XmlAttribute]
		public string leadingOnBoardUnitId {get;set;}
	}
}