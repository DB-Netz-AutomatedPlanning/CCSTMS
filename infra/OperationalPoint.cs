using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "operationalPoint")]
	public class OperationalPoint
	{
		[XmlArrayItem("travelTimeMeasurementPoint", Namespace = "https://erju.org/infra")]
		public List<TravelTimeMeasurementPointRef> travelTimeMeasurementPoints;
		[XmlArrayItem("platform", Namespace = "https://erju.org/infra")]
		public List<infra.Platform> platforms;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string name {get;set;}
		[XmlAttribute]
		public infra.OPType type {get;set;}
	}
}