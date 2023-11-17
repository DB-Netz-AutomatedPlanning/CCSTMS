using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "platformHeight")]
	public enum PlatformHeight
	{
		PH_200mm,
		PH_300_380mm,
		PH_550mm,
		PH_580mm,
		PH_680mm,
		PH_685mm,
		PH_730mm,
		PH_760mm,
		PH_840mm,
		PH_900mm,
		PH_915mm,
		PH_920mm,
		PH_960mm,
		PH_1100mm,
	}
}