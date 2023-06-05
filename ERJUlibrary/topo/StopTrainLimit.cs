using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "stopTrainLimit")]
	public struct StopTrainLimit
	{
        public StopTrainLimitLength trainLimitLength;
        public StopTrainLimitAxles trainLimitAxles;		
		public StopTrainLimitWagons trainLimitWagons;
		public StopTrainLimitSize trainLimitSize;
	}
}