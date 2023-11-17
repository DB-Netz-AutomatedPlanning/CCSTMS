using System.Xml.Serialization;
namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "positionType")]
	public enum PositionType
	{
		PositionOnTrack,
		LogicalPosition,
	}
}