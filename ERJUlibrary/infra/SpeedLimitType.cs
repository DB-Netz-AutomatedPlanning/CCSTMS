using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
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