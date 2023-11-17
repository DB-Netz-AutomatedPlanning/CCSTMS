using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "doorOpeningSide")]
	public enum DoorOpeningSide
	{
		noSide,
		leftSide,
		rightSide,
		bothSides,
	}
}