using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "operationalMovementMarker")]
	public class OperationalMovementMarker
	{
		public tt.TemporarySpeedRestrictionMarker? tsrMarker {get;set;}
		public tt.LowAdhesionMarker? lowAdhesionMarker {get;set;}
	}
}