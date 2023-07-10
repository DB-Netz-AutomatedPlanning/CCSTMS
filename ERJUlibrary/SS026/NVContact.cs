using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "nVContact")]
	public enum NVContact
	{
		trainTrip,
		applyServiceBrake,
		noReaction,
		spare,
}