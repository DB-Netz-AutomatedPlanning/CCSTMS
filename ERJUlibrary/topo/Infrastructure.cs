using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "infrastructure")]
	public struct Infrastructure
	{		
		[XmlArrayItem("topoArea", Namespace = "https://erju.org/topo")]
		public List<TopoArea> topoAreas;		
		[XmlArrayItem("geometryArea", Namespace = "https://erju.org/topo")]
		public List<GeometryArea> geometryAreas;		
		[XmlArrayItem("sampledGeometryArea", Namespace = "https://erju.org/topo")]
		public List<SampledGeometryArea> sampledGeometryAreas;		
		[XmlArrayItem("propertiesArea", Namespace = "https://erju.org/topo")]
		public List<PropertiesArea> propertiesAreas;		
		[XmlArrayItem("mileageArea", Namespace = "https://erju.org/topo")]
		public List<MileageArea> mileageAreas;		
		[XmlArrayItem("mapArea", Namespace = "https://erju.org/topo")]
		public List<MapArea> mapAreas;
	}
}