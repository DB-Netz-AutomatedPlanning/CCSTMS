using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "sampledTrackEdgeGeometry")]
	public class SampledTrackEdgeGeometry
	{
		[XmlArrayItem("slope", Namespace = "https://erju.org/infra")]
		public List<infra.SlopeSamplePoint> slopes;
		[XmlArrayItem("curve", Namespace = "https://erju.org/infra")]
		public List<infra.CurveSamplePoint> curves;
		[XmlArrayItem("cant", Namespace = "https://erju.org/infra")]
		public List<infra.CantSamplePoint> cants;
		[XmlAttribute]
		public string id {get;set;}
	}
}