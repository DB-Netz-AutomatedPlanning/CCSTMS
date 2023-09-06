using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "linkDirection")]
	public enum LinkDirection
	{
		linkDirBoth,
		linkDirAB,
		linkDirBA
	}
}
