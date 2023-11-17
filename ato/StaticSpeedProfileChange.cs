using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "staticSpeedProfileChange")]
	public class StaticSpeedProfileChange
	{
		[XmlArrayItem("specificStaticSpeedProfileItem", Namespace = "https://erju.org/ato")]
		public List<ato.SpecificStaticSpeedProfileChange> specificStaticSpeedProfile;
		[XmlAttribute]
		public uint pos {get;set;}
		[XmlAttribute]
		public uint speed {get;set;}
		[XmlAttribute]
		public ato.TrainEndApplicability trainEndApplicability {get;set;}
	}
}