using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/tt2", ElementName = "trainUnitActivity")]
	public class TrainUnitActivity
	{
		[XmlAttribute]
		public tt2.ActivityType type {get;set;}
		[XmlAttribute]
		public uint actualTrainUnitIndex {get;set;}
		[XmlAttribute]
		public uint targetTrainUnitIndex {get;set;}
	}
}