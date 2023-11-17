using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "eTCSMarker")]
	public class ETCSMarker
	{
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string trackEdge {get;set;}
		[XmlAttribute]
		public uint pos {get;set;}
		[XmlAttribute]
		public bool sameDir {get;set;}
		[XmlAttribute]
		public bool markerFunctionStop {get;set;}
	}
}