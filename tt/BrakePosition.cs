using System.Xml.Serialization;
namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "brakePosition")]
	public enum BrakePosition
	{
		passengerTrainInP,
		freightTrainInP,
		freightTrainInG,
		unknown,
	}
}