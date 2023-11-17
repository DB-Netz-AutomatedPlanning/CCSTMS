using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "anyClass")]
	public class AnyClass
	{
		[XmlAttribute]
		public string className {get;set;}
		[XmlAttribute]
		public string content {get;set;}
	}
}