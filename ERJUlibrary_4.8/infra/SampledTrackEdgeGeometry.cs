using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "sampledTrackEdgeGeometry")]
	public class SampledTrackEdgeGeometry
	{
		private string id;
		[XmlAttribute(AttributeName = "id")]
		public string Id
		{
			set
			{
				this.id = value;
			}
			get
			{
				return this.id != null?  this.id : "";
			}
}
		[XmlArrayItem("slope", Namespace = "https://erju.org/infra")]
		public List<SlopeSamplePoint> slopes;
		[XmlArrayItem("curve", Namespace = "https://erju.org/infra")]
		public List<CurveSamplePoint> curves;
		[XmlArrayItem("cant", Namespace = "https://erju.org/infra")]
		public List<CantSamplePoint> cants;

	}
}
