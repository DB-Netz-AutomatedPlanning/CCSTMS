using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "stopTrainLimitWagons")]
	public class StopTrainLimitWagons
	{		
		[XmlAttribute]
		public uint maxWagonNumber;
	}
}