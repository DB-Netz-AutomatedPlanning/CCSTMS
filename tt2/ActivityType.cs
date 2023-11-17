using System.Xml.Serialization;
namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "activityType")]
	public enum ActivityType
	{
		joinActivity,
		splitActivity,
		collectActivity,
		dropActivity,
		reverseActivity,
	}
}