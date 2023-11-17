using System.Xml.Serialization;
namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainCategoryType")]
	public enum TrainCategoryType
	{
		INTERREGIONAL,
		REGIONAL,
		SUB_URBAN,
		NIGHT_TRAIN,
		MOTOR_RAIL,
		MOUNTAIN_TRAIN,
		HISTORIC_TRAIN,
		COACH_GROUP,
		TRAM,
		UNDERGROUND,
		HIGHSPEED_TRAIN,
		INTERCITY,
	}
}