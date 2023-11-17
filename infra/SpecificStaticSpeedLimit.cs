using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "specificStaticSpeedLimit")]
	public class SpecificStaticSpeedLimit
	{
		public infra.SpeedLimitType? specificLimitType {get;set;}
		[XmlAttribute]
		public uint speed {get;set;}
	}
}