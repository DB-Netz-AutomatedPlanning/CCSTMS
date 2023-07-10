using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "linkReaction")]
	public enum LinkReaction
	{
		trainTrip,
		applyServiceBrake,
		noReaction,
		spare,
}