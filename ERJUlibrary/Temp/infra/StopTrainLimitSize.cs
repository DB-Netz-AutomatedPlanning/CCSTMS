using infra;
using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "stopTrainLimitSize")]
	public class StopTrainLimitSize
	{
		[XmlAttribute]
		public StopTrainLimitSizeEnum trainSize { get; set; }
	}
}