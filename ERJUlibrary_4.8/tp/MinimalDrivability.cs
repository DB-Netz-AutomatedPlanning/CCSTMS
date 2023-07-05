using System.Xml.Serialization;
using System.Collections.Generic;
namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "minimalDrivability")]
	public enum MinimalDrivability
	{
		none,
		full,
		limited,
	}
}
