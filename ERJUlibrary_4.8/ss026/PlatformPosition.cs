using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "platformPosition")]
	public enum PlatformPosition
	{
		PP_left,
		PP_right,
		PP_both,
		PP_spare
	}
}
