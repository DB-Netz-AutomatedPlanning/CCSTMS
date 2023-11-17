using System.Xml.Serialization;
namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "doorSide")]
	public enum DoorSide
	{
		noneSide,
		rightSide,
		leftSide,
		bothSides,
	}
}