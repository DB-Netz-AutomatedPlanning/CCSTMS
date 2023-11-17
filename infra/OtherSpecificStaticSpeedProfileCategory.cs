using System.Xml.Serialization;
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