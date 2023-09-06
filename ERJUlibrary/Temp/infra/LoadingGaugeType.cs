using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
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