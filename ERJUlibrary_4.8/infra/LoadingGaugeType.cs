using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "loadingGaugeType")]
	public enum LoadingGaugeType
	{
		g1,
		g2,
		gA,
		gB,
		gC,
	}
}
