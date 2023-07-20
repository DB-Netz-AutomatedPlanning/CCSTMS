using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "kVType")]
	public enum KVType
	{
		freightTrains,
		conventionalPassengerTrains,
		other,
}