using System.Xml.Serialization;
namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainProtectionType")]
	public enum TrainProtectionType
	{
		Etcs,
	}
}