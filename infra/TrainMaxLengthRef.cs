using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainMaxLength")]
	public class TrainMaxLengthRef
	{
		[XmlAttribute(AttributeName ="value")]
		public uint value {get;set;}
	}
}