using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "stopTrainLimit")]
	public class StopTrainLimit
	{
        public StopTrainLimitLength trainLimitLength;
        public StopTrainLimitAxles trainLimitAxles;		
		public StopTrainLimitWagons trainLimitWagons;
		public StopTrainLimitSize trainLimitSize;
	}
}
