using System.Xml.Serialization;
namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "loadingDirection")]
	public enum LoadingDirection
	{
		bothDirections,
		onTrain,
		offTrain,
	}
}