using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "stopTrainLimit")]
	public class StopTrainLimit
	{
		public TrainMaxLengthRef? trainMaxLength {get;set;}
		public TrainMaxAxlesRef? trainMaxAxles {get;set;}
		public TrainMaxWagonsRef? trainMaxWagons {get;set;}
		public TrainMaxSizeRef? trainMaxSize {get;set;}
	}
}