using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "baliseGroupFunction")]
	public enum BaliseGroupFunction
	{
		location,
		sessionManagement,
		networkRegistration,
	}
}