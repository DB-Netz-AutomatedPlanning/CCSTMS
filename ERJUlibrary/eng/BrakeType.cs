using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "brakeType")]
	public enum BrakeType
	{
		serviceBrake,
		emergencyBrake,
	}
}