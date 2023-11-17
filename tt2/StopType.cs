using System.Xml.Serialization;
namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "stopType")]
	public enum StopType
	{
		COMMERCIAL,
		OPERATIONAL,
		CONDITIONAL,
	}
}