using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "linkReaction")]
	public enum LinkReaction
	{
		trainTrip,
		applyServiceBrake,
		noReaction,
		spare,
	}
}