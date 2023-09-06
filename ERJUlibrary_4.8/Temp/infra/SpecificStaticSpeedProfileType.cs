using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "specificStaticSpeedProfileType")]
	public enum SpecificStaticSpeedProfileType
	{
		cantDeficiency,
		otherSpecificSSP,
	}
}
