using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "staticSpeedProfileChange")]
	public class StaticSpeedProfileChange
	{		
		[XmlAttribute]
		public uint pos;		
		[XmlArrayItem("specificStaticSpeedProfileChange", Namespace = "https://erju.org/ato")]
		public List<SpecificStaticSpeedProfileChange> specificStaticSpeedProfile;		
		[XmlAttribute]
		public uint speed;
		[XmlAttribute]
		public TrainEndApplicability trainEndApplicability;
	}
}
