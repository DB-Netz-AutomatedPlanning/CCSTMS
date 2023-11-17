using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainSize")]
	public enum TrainSize
	{
		shortTrain,
		halfTrain,
		fullTrain,
	}
}