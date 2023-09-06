using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "baliseGroupFunction")]
	public enum BaliseGroupFunction
	{
		location,
		sessionManagement,
		networkRegistration,	
	}
}
