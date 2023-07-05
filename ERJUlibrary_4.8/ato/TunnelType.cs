using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "tunnelType")]
	public enum TunnelType
	{
		singleTrackTunnel,
		doubleTrackTunnel,
		wideCrossSectionTunnel,
	}
}
