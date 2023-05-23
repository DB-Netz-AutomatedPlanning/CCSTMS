using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "stopTrainLimitWagons")]
	public struct StopTrainLimitWagons
	{		
		[XmlAttribute]
		public uint maxWagonNumber;
	}
}