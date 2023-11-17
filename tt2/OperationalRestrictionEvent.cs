using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/tt2", ElementName = "operationalRestrictionEvent")]
	public class OperationalRestrictionEvent
	{
		[XmlAttribute]
		public string id {get;set;}
	}
}