using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "specificStaticSpeedLimit")]
	public class SpecificStaticSpeedLimit
	{		
		[XmlAttribute]
		public uint speed;		
		public SpeedLimitType? specificLimitType;
	}
}