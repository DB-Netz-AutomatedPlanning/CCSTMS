using System.Xml.Serialization;
using System.Collections.Generic;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "bufferStop")]
	public class BufferStop
	{
		[XmlArrayItem("dangerPoint", Namespace = "https://erju.org/eng")]
		public List<DangerPointRef> dangerPoints;
		[XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/eng")]
		public List<infra.TrackEdgeSection> trackEdgeSections;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public eng.BufferStopType bsType {get;set;}
	}
}