using System.Xml.Serialization;
namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "eventType")]
	public enum EventType
	{
		PASSAGE,
		STOP,
		OTHER_EVENT,
	}
}