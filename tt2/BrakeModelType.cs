using System.Xml.Serialization;
namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "brakeModelType")]
	public enum BrakeModelType
	{
		lambda,
		gamma,
	}
}