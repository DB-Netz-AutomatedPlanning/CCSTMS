using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "platformEdge")]
	public class PlatformEdge
	{
		[XmlElement(Order = 0)]
		public infra.LinkedPath? linearLocation {get;set;}
		[XmlArrayItem("stopLocation", Namespace = "https://erju.org/infra"),XmlArray(Order =1)]
		public List<StopLocationRef> stopLocations;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string name {get;set;}
		[XmlAttribute]
		public infra.PlatformHeight height {get;set;}
	}
}