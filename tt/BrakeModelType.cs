using System.Xml.Serialization;
namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "brakeModelType")]
	public enum BrakeModelType
	{
		lambda,
		gamma,
	}
}