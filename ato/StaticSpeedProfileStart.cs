using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "staticSpeedProfileStart")]
	public class StaticSpeedProfileStart
	{
		[XmlArrayItem("specificStaticSpeedProfileItem", Namespace = "https://erju.org/ato")]
		public List<ato.SpecificStaticSpeedProfileStart> specificStaticSpeedProfile;
		[XmlAttribute]
		public uint speed {get;set;}
		[XmlAttribute]
		public ato.TrainEndApplicability trainEndApplicability {get;set;}
	}
}