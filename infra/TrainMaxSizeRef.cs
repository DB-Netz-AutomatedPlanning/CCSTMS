using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainMaxSize")]
	public class TrainMaxSizeRef
	{
		[XmlAttribute(AttributeName ="value")]
		public string value {get;set;}
	}
}