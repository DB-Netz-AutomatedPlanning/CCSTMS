using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "maxAxleLoad")]
	public class MaxAxleLoadRef
	{
		[XmlAttribute(AttributeName ="value")]
		public uint value {get;set;}
	}
}