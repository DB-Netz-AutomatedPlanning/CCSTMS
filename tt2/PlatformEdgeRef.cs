using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "platformEdge")]
	public class PlatformEdgeRef
	{
		[XmlAttribute(AttributeName ="ref")]
		public string Ref {get;set;}
	}
}