using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "sampledGeometryArea")]
	public class SampledGeometryArea
	{
		[XmlArrayItem("sampledTrackEdgeGeometry", Namespace = "https://erju.org/infra")]
		public List<infra.SampledTrackEdgeGeometry> sampledTrackEdgeGeometries;
		[XmlAttribute]
		public string id {get;set;}
	}
}