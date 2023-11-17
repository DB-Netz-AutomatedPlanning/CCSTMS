using System.Xml.Serialization;
namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "adhesionCategory")]
	public enum AdhesionCategory
	{
		dryRail,
		medium,
		normal_low,
		lowAdhesion,
		veryLowAdhesion,
		extremelyLowAdhesion,
	}
}