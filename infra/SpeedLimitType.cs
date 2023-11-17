using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "speedLimitType")]
	public class SpeedLimitType
	{
		public OtherCategoryRef? otherCategory {get;set;}
		public CantDeficiencyRef? cantDeficiency {get;set;}
	}
}