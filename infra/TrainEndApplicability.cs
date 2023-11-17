using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainEndApplicability")]
	public enum TrainEndApplicability
	{
		lengthDelay,
		noLengthDelay,
	}
}