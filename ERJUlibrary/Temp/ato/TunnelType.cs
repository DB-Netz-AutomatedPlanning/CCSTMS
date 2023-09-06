using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
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