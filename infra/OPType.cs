using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "oPType")]
	public enum OPType
	{
		station,
		depot,
		siding,
		trainTechnicalServices,
		shuntingYard,
		borderPoint,
		technicalChange,
	}
}