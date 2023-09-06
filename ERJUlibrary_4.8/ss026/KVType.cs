using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "kVType")]
	public enum KVType
	{
		freightTrains,
		conventionalPassengerTrains,
		spare
	}
}
