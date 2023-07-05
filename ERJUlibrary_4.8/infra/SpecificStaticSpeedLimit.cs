using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "specificStaticSpeedLimit")]
	public class SpecificStaticSpeedLimit
	{		
		[XmlAttribute]
		public uint speed;		
		public SpeedLimitType specificLimitType;
	}
}
