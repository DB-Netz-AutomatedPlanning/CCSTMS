using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "stopTrainLimitLength")]
	public class StopTrainLimitLength
	{		
		[XmlAttribute]
		public uint maxTrainLength;
	}
}
