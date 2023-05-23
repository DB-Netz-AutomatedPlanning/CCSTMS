using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "loadingGaugeType")]
	public enum LoadingGaugeType
	{
		g1,
		g2,
		gA,
		gB,
		gC,
	}
}