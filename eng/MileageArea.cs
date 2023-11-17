using System.Xml.Serialization;
using System.Collections.Generic;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "mileageArea")]
	public class MileageArea
	{
		[XmlArrayItem("mileageLine", Namespace = "https://erju.org/eng")]
		public List<eng.MileageLine> mileageLines;
		[XmlAttribute]
		public string id {get;set;}
	}
}