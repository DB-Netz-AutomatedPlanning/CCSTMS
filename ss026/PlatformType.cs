using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "platformType")]
	public enum PlatformType
	{
		PT_200,
		PT_300_380,
		PT_550,
		PT_580,
		PT_680,
		PT_685,
		PT_730,
		PT_760,
		PT_840,
		PT_900,
		PT_915,
		PT_920,
		PT_960,
		PT_1100,
		PT_spare,
	}
}