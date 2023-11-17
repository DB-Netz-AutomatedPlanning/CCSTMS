using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainLoadType")]
	public enum TrainLoadType
	{
		passengerTrain,
		freightTrain,
		anyTrain,
	}
}