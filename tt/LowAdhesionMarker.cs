using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "lowAdhesionMarker")]
	public class LowAdhesionMarker
	{
		public infra.TrackEdgePoint? trackEdgePoint {get;set;}
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public uint sequence {get;set;}
		[XmlAttribute]
		public bool isStart {get;set;}
		[XmlAttribute]
		public tt.AdhesionCategory adhesionCategory {get;set;}
		[XmlAttribute]
		public bool observingPointHead {get;set;}
	}
}