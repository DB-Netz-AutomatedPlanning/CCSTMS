using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "nVContact")]
	public enum NVContact
	{
		trainTrip,
		applyServiceBrake,
		noReaction,
		spare
	}
}
