using System.Xml.Serialization;
using System.Collections.Generic;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "sleepersType")]
	public enum SleepersType
	{
		composite,
		concrete,
		steel,
		wood,
	}
}
