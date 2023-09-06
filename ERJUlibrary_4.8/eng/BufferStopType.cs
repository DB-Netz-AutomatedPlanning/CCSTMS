using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "bufferStopType")]
	public enum BufferStopType
	{
		friction,
		hydraulic,
		fixated,
		other
	}
}
