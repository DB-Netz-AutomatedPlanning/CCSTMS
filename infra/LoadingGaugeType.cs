using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "loadingGaugeType")]
	public enum LoadingGaugeType
	{
		loadingGaugeIncompatible,
		g1,
		gA,
		gB,
		gC,
	}
}