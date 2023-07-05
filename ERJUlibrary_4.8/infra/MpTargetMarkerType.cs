using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "mpTargetMarkerType")]
	public enum MpTargetMarkerType
	{
		ETCSMarker,
		StopLocation,
		Balise,
	}
}
