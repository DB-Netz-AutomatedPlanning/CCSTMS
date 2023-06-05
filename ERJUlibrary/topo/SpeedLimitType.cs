using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "speedLimitType")]
	public struct SpeedLimitType
	{		
		[XmlAttribute]
public OtherSpecificStaticSpeedProfileCategory otherCategory;		
		[XmlAttribute]
public CantDeficiencyCategory cantDeficiency;
	}
}