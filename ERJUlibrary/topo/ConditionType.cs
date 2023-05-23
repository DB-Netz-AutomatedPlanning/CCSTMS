using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "conditionType")]
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