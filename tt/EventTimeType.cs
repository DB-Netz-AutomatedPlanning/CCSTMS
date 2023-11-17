using System.Xml.Serialization;
namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "eventTimeType")]
	public enum EventTimeType
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
		creation,
		removal,
	}
}