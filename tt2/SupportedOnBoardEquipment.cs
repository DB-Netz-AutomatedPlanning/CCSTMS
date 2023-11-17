using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/tt2", ElementName = "supportedOnBoardEquipment")]
	public class SupportedOnBoardEquipment
	{
		[XmlArrayItem("anyClas", Namespace = "https://erju.org/tt2")]
		public List<tt2.AnyClass> anyClass;
		[XmlAttribute]
		public tt2.TrainProtectionType type {get;set;}
		[XmlAttribute]
		public string etcsVersions {get;set;}
	}
}