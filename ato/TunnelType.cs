using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "tunnelType")]
	public enum TunnelType
	{
		singleTrackTunnel,
		doubleTrackTunnel,
		wideCrossSectionTunnel,
	}
}