using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/tt", ElementName = "operationalConsist")]
	public class OperationalConsist
	{
		public tt.SupportedOnBoardEquipment? supportedOnBoardEquipment {get;set;}
		[XmlAttribute]
		public string id {get;set;}
	}
}