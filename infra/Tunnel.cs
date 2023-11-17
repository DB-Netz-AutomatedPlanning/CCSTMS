using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "tunnel")]
	public class Tunnel
	{
		[XmlArrayItem("tunnelTube", Namespace = "https://erju.org/infra")]
		public List<infra.TunnelTube> tunnelTubes;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string name {get;set;}
	}
}