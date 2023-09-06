using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
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