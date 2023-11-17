using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "stopActivity")]
	public class StopActivity
	{
		[XmlAttribute]
		public tt.ActivityType type {get;set;}
		[XmlAttribute]
		public string actualOperationalSegment {get;set;}
		[XmlAttribute]
		public string targetOperationalSegment {get;set;}
	}
}