using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
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
		public List<SpecificStaticSpeedLimit>? specificStaticSpeedLimits;
	}
}