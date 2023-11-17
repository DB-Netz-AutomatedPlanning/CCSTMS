using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "operationalMovementEventPosition")]
	public class OperationalMovementEventPosition
	{
		public infra.TrackEdgePoint? trackEdgePoint {get;set;}
		[XmlAttribute]
		public tt.PositionType type {get;set;}
	}
}