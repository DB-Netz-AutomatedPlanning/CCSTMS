using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "direction")]
	public enum Direction
	{
		dirBoth,
		dirSame,
		dirReverse,
	}
}