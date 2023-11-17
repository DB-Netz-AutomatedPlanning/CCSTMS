using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "funcElementRef")]
	public class FuncElementRef
	{
		public SimplePointRef? simplePoint {get;set;}
		public EtcsMarkerRef? etcsMarker {get;set;}
		public StopLocationRef? stopLocation {get;set;}
		public TimingPointRef? timingPoint {get;set;}
		public OperationalPointRef? operationalPoint {get;set;}
		public BaliseRef? balise {get;set;}
	}
}