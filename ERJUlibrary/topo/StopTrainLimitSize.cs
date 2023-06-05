using ERJUlibrary.topo;
using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "stopTrainLimitSize")]
	public struct StopTrainLimitSize
	{
		[XmlAttribute]
		public StopTrainLimitSizeEnum trainSize { get; set; }
	}
}