using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "textConfirmationType")]
	public enum TextConfirmationType
	{
		TCT_00,
		TCT_01,
		TCT_10,
		TCT_11
	}
}
