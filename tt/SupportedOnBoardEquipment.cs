using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "supportedOnBoardEquipment")]
	public class SupportedOnBoardEquipment
	{
		[XmlArrayItem("anyClas", Namespace = "https://erju.org/tt")]
		public List<tt.AnyClass> anyClass;
		[XmlAttribute]
		public tt.TrainProtectionType type {get;set;}
		[XmlAttribute]
		public string etcsVersions {get;set;}
	}
}