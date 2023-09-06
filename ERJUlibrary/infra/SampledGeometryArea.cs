using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "sampledGeometryArea")]
	public class SampledGeometryArea
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
		private string name;
		[XmlAttribute(AttributeName = "name")]
		public string Name
		{
			set
			{
				this.name = value;
			}
			get
			{
				return this.name != null?  this.name : "";
			}
}
		[XmlArrayItem("sampledTrackEdgeGeometry", Namespace = "https://erju.org/infra")]
		public List<SampledTrackEdgeGeometry> sampledTrackEdgeGeometries;

	}
}
