using System.Xml.Serialization;
using System.Collections.Generic;
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
