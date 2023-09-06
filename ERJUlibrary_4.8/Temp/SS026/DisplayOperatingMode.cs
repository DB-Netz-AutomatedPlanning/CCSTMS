using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "displayOperatingMode")]
	public enum DisplayOperatingMode
	{
		fullSupervision,
		onSight,
		staffResponsible,
		unfitted,
		standBy,
		trip,
		postTrip,
		limitedSupervision,
		other,
		reversing,
		notLimitedByMode,
}