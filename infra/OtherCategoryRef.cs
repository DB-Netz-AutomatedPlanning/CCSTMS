using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "otherCategory")]
	public class OtherCategoryRef
	{
		[XmlAttribute(AttributeName ="value")]
		public string value {get;set;}
	}
}