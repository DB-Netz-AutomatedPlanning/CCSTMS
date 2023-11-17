using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "specificStaticSpeedProfileType")]
	public enum SpecificStaticSpeedProfileType
	{
		cantDeficiency,
		otherSpecificSSP,
	}
}