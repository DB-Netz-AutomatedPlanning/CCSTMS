using System.Xml.Serialization;
namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "eventType")]
	public enum EventType
	{
		PASSAGE,
		STOP,
		OTHER_EVENT,
	}
}