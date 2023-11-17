using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "routeSuitability")]
	public class RouteSuitability
	{
		public LoadingGaugeRef? loadingGauge {get;set;}
		public MaxAxleLoadRef? maxAxleLoad {get;set;}
		public ss026.TractionSystem? voltage {get;set;}
	}
}