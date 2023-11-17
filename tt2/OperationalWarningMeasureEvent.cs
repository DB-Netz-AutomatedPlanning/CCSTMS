using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/tt2", ElementName = "operationalWarningMeasureEvent")]
	public class OperationalWarningMeasureEvent
	{
		[XmlAttribute]
		public string id {get;set;}
	}
}