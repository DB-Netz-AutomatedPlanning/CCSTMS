using System.Xml.Serialization;
namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "positionType")]
	public enum PositionType
	{
		PositionOnTrack,
		LogicalPosition,
	}
}