using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackCondType")]
	public enum TrackCondType
	{
		TCT_0000,
		TCT_0001,
		TCT_0010,
		TCT_0011,
		TCT_0100,
		TCT_0101,
		TCT_0110,
		TCT_0111,
		TCT_1000,
		TCT_1001,
		TCT_1010,
		TCT_0011_1111,
	}
}