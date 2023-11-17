using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/tt2", ElementName = "operationalConsist")]
	public class OperationalConsist
	{
		public tt2.SupportedOnBoardEquipment? supportedOnBoardEquipment {get;set;}
		[XmlAttribute]
		public string id {get;set;}
	}
}