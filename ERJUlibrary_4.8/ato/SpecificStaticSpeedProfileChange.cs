using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "specificStaticSpeedProfileChange")]
	public class SpecificStaticSpeedProfileChange
	{		
		[XmlAttribute]
		public uint speed;		 
		[XmlAttribute]
        public infra.SpecificStaticSpeedProfileType specificStaticSpeedProfileType;		
		[XmlAttribute]
        public infra.OtherSpecificStaticSpeedProfileCategory otherSpecificStaticSpeedProfileCategory;		
		[XmlAttribute]
		public infra.CantDeficiencyCategory cantDeficiencyCategory;
	}
}
