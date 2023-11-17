using System.Xml.Serialization;
namespace tt2
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