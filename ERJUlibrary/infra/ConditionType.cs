using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "conditionType")]
	public enum ConditionType
	{
		powerlessLowPanthograph,
		powerlessMainSwitch,
		airTighntness,
		soundHorn,
		nonStoppingArea,
		tunnelStoppingArea,
		bigMetalMasses,
		radioHole,
	}
}