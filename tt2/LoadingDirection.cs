using System.Xml.Serialization;
namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "loadingDirection")]
	public enum LoadingDirection
	{
		bothDirections,
		onTrain,
		offTrain,
	}
}