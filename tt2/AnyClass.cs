using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/tt2", ElementName = "anyClass")]
	public class AnyClass
	{
		[XmlAttribute]
		public string className {get;set;}
		[XmlAttribute]
		public string content {get;set;}
	}
}