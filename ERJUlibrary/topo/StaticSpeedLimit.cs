using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "staticSpeedLimit")]
	public struct StaticSpeedLimit
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public uint speed;		
		[XmlArrayItem("specificStaticSpeedLimit", Namespace = "https://erju.org/topo")]
		public List<SpecificStaticSpeedLimit> specificStaticSpeedLimits;
	}
}