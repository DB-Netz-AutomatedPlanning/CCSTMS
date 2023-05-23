using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "stopTrainLimitLength")]
	public struct StopTrainLimitLength
	{		
		[XmlAttribute]
		public uint maxTrainLength;
	}
}