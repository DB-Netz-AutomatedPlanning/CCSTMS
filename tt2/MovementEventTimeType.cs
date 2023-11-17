using System.Xml.Serialization;
namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "movementEventTimeType")]
	public enum MovementEventTimeType
	{
		earliestOperationalDeparture,
		latestOperationalDeparture,
		earliestOperationalArrival,
		lastOperationalArrival,
		operationalDeparture,
		publishedArrival,
		publishedDeparture,
		realisedArrival,
		realisedDeparture,
	}
}