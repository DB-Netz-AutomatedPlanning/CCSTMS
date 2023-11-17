using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "sleepersType")]
	public enum SleepersType
	{
		unknownSleepersType,
		composite,
		concrete,
		steel,
		wood,
	}
}