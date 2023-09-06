using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "textClass")]
	public enum TextClass
	{
		TC_auxiliary,
		TC_important,
		TC_spare
	}
}
