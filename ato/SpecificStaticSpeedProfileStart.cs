using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "specificStaticSpeedProfileStart")]
	public class SpecificStaticSpeedProfileStart
	{
		[XmlAttribute]
		public uint speed {get;set;}
		[XmlAttribute]
		public infra.SpecificStaticSpeedProfileType specificStaticSpeedProfileType {get;set;}
		[XmlAttribute]
		public infra.OtherSpecificStaticSpeedProfileCategory otherSpecificStaticSpeedProfileCategory {get;set;}
		[XmlAttribute]
		public infra.CantDeficiencyCategory cantDeficiencyCategory {get;set;}
	}
}