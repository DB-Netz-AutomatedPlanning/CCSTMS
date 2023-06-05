using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "specificStaticSpeedLimit")]
	public struct SpecificStaticSpeedLimit
	{		
		[XmlAttribute]
		public uint speed;		
		public SpeedLimitType specificLimitType;
	}
}