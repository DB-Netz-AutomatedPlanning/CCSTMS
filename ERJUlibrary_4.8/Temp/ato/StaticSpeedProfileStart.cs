using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "staticSpeedProfileStart")]
	public class StaticSpeedProfileStart
	{		
		[XmlArrayItem("specificStaticSpeedProfileStart", Namespace = "https://erju.org/ato")]
		public List<SpecificStaticSpeedProfileStart> specificStaticSpeedProfile;		
		[XmlAttribute]
		public uint speed;		
		[XmlAttribute]
		public TrainEndApplicability trainEndApplicability;
	}
}
