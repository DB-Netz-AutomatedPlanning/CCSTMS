using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "oPType")]
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