using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "platformPosition")]
	public enum PlatformPosition
	{
		PP_left,
		PP_right,
		PP_both,
		PP_spare,
	}
}