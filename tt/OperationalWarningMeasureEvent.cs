using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "operationalWarningMeasureEvent")]
	public class OperationalWarningMeasureEvent
	{
		[XmlAttribute]
		public string id {get;set;}
	}
}