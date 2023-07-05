using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "infrastructure")]
    public class Infrastructure
	{
        [XmlArrayItem("topoArea", Namespace = "https://erju.org/infra")]
		public List<TopoArea> topoAreas;		
		[XmlArrayItem("geometryArea", Namespace = "https://erju.org/infra")]
		public List<GeometryArea> geometryAreas;		
		[XmlArrayItem("sampledGeometryArea", Namespace = "https://erju.org/infra")]
		public List<SampledGeometryArea> sampledGeometryAreas;
        [XmlArrayItem("functionalArea", Namespace = "https://erju.org/infra")]
        public List<FunctionalArea> functionalAreas;
        [XmlArrayItem("propertiesArea", Namespace = "https://erju.org/infra")]
		public List<PropertiesArea> propertiesAreas;		
		[XmlArrayItem("mileageArea", Namespace = "https://erju.org/infra")]
		public List<MileageArea> mileageAreas;		
		[XmlArrayItem("mapArea", Namespace = "https://erju.org/infra")]
		public List<MapArea> mapAreas;

    }
}
