using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "stopTrainLimit")]
	public class StopTrainLimit
	{
		[XmlAttribute]
		public uint trainMaxLength;
		[XmlAttribute]
		public uint trainMaxAxles;
		[XmlAttribute]
		public uint trainMaxWagons;
		[XmlAttribute]
		public TrainSize trainMaxSize;

	}
}
