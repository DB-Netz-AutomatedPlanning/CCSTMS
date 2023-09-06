using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "displayOperatingMode")]
	public enum DisplayOperatingMode
	{
		DOM_fullSupervision,
		DOM_onSight,
		DOM_staffResponsible,
		DOM_spare,
		DOM_unfitted,
		DOM_spare1,
		DOM_standBy,
		DOM_trip,
		DOM_postTrip,
		DOM_spare2,
		DOM_spare3,
		DOM_spare4,
		DOM_limitedSupervision,
		DOM_spare5,
		DOM_reversing,
		DOM_notLimitedByMode
	}
}
