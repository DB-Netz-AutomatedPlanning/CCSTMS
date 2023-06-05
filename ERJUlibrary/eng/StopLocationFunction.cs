using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "stopLocationFunction")]
	public enum StopLocationFunction
	{
		generic,
		basedOnTrainLength,
	}
}