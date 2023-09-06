using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "mapArea")]
	public class MapArea
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
		private string areaId;
		[XmlAttribute(AttributeName = "areaId")]
		public string AreaId
		{
			set
			{
				this.areaId = value;
			}
			get
			{
				return this.areaId != null?  this.areaId : "";
			}
}
		[XmlAttribute]
		public uint epsg;
		[XmlArrayItem("trackEdge", Namespace = "https://erju.org/infra")]
		public List<TrackEdgeProjection> trackEdges;
		[XmlArrayItem("funcElement", Namespace = "https://erju.org/infra")]
		public List<FuncElementProjection> funcElements;

	}
}
