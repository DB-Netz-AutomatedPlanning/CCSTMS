using System.Xml.Serialization;
namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainUsageType")]
	public enum TrainUsageType
	{
		COMMERCIAL_PASSENGER_TRAIN,
		COMMERCIAL_CARGO_TRAIN,
		LOCOMOTIVE_RUNNING_LIGHT,
		LIGHT_RUNNING,
		NOT_IN_SERVICE,
		ENGINEERING_TRAIN,
		BREAKDOWN_TRAIN,
		MIXED_TRAIN,
		SPECIAL_TRAIN,
		OTHER_TRAIN,
	}
}