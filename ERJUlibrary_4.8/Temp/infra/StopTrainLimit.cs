using System.Xml.Serialization;
using System.Collections.Generic;
using ERJUlibrary_4._8.infra;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "stopTrainLimit")]
	public class StopTrainLimit
	{
        public uint trainMaxLength;
        public uint trainMaxAxles;		
		public uint trainMaxWagons;
		public TrainSize trainMaxSize;
	}
}
