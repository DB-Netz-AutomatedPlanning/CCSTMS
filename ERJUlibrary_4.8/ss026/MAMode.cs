using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "mAMode")]
	public enum MAMode
	{
		MAM_OS,
		MAM_LS,
		MAM_SH,
		MAM_Spare
	}
}
