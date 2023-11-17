using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "staticSpeedLimit")]
	public class StaticSpeedLimit
	{
		[XmlArrayItem("specificStaticSpeedLimit", Namespace = "https://erju.org/infra")]
		public List<infra.SpecificStaticSpeedLimit> specificStaticSpeedLimits;
		[XmlAttribute]
		public uint pos {get;set;}
		[XmlAttribute]
		public uint speed {get;set;}
	}
}