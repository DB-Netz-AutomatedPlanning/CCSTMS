using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "operationalRestrictionEvent")]
	public class OperationalRestrictionEvent
	{
		[XmlAttribute]
		public string id {get;set;}
	}
}