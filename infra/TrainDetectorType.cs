using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainDetectorType")]
	public enum TrainDetectorType
	{
		axleCounter,
		trackCircuitBorder,
	}
}