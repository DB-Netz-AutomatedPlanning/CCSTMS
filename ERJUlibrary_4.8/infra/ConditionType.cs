using System.Xml.Serialization;
using System.Collections.Generic;
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
