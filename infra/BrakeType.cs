using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "brakeType")]
	public enum BrakeType
	{
		serviceBrake,
		emergencyBrake,
	}
}