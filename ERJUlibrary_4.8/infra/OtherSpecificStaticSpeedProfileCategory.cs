using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "otherSpecificStaticSpeedProfileCategory")]
	public enum OtherSpecificStaticSpeedProfileCategory
	{
		freightTrainP,
		freightTrainG,
		passengerTrain,
	}
}
