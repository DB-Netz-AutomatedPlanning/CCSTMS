using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "stopTrainLimitLength")]
	public class StopTrainLimitLength
	{		
		[XmlAttribute]
		public uint maxTrainLength;
	}
}