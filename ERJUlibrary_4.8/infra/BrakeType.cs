using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "braketype")]
	public enum BreakType
	{
        serviceBrake,
        emergencyBrake
	}
}
