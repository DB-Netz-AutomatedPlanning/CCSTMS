using System.Xml.Serialization;
namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "stopType")]
	public enum StopType
	{
		COMMERCIAL,
		OPERATIONAL,
		CONDITIONAL,
	}
}