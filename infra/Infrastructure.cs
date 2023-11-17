﻿using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "infrastructure")]
	public class Infrastructure
	{
		[XmlArrayItem("topoArea", Namespace = "https://erju.org/infra")]
		public List<infra.TopoArea> topoAreas;
		[XmlArrayItem("geometryArea", Namespace = "https://erju.org/infra")]
		public List<infra.GeometryArea> geometryAreas;
		[XmlArrayItem("sampledGeometryArea", Namespace = "https://erju.org/infra")]
		public List<infra.SampledGeometryArea> sampledGeometryAreas;
		[XmlArrayItem("functionalArea", Namespace = "https://erju.org/infra")]
		public List<infra.FunctionalArea> functionalAreas;
		[XmlArrayItem("propertiesArea", Namespace = "https://erju.org/infra")]
		public List<infra.PropertiesArea> propertiesAreas;
		[XmlArrayItem("mapArea", Namespace = "https://erju.org/infra")]
		public List<infra.MapArea> mapAreas;
	}
}