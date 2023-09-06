using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "speedLimitType")]
	public class SpeedLimitType
	{		
		[XmlAttribute]
public OtherSpecificStaticSpeedProfileCategory otherCategory;		
		[XmlAttribute]
public CantDeficiencyCategory cantDeficiency;
	}
}
