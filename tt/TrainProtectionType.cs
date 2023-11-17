using System.Xml.Serialization;
namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainProtectionType")]
	public enum TrainProtectionType
	{
		Etcs,
	}
}