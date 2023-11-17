using System.Xml.Serialization;
namespace tt
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