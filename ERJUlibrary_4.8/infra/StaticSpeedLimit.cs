using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "staticSpeedLimit")]
	public class StaticSpeedLimit
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public uint speed;		
		[XmlArrayItem("specificStaticSpeedLimit", Namespace = "https://erju.org/infra")]
		public List<SpecificStaticSpeedLimit> specificStaticSpeedLimits;
	}
}
