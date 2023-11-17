using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "conditionType")]
	public enum ConditionType
	{
		powerlessLowPanthograph,
		powerlessMainSwitch,
		airTightness,
		soundHorn,
		nonStoppingArea,
		tunnelStoppingArea,
		bigMetalMasses,
		radioHole,
		switchOffRegenerativeBrake,
		switchOffEddyCurrentBrakeForServiceBrake,
		switchOffEddyCurrentBrakeForEmergencyBrake,
		switchOffMagneticShoeBrake,
	}
}