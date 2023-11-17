using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "temporarySpeedRestrictionMarker")]
	public class TemporarySpeedRestrictionMarker
	{
		public infra.TrackEdgePoint? trackEdgePoint {get;set;}
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public uint sequence {get;set;}
		[XmlAttribute]
		public bool isStart {get;set;}
		[XmlAttribute]
		public uint maximumSpeedRestriction {get;set;}
		[XmlAttribute]
		public bool observingPointHead {get;set;}
	}
}