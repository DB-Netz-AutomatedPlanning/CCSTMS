using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "stopTrainLimitSize")]
	public class StopTrainLimitSize
	{
        [XmlAttribute]
        public StopTrainLimitSizeEnum trainSize;
    }
}
