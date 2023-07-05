using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "stopTrainLimitAxles")]
	public class StopTrainLimitAxles
	{		
		[XmlAttribute]
		public uint maxTrainLength;
	}
}
