using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "staticSpeedProfileChange")]
	public class StaticSpeedProfileChange
	{		
		[XmlAttribute]
		public uint p;		
		[XmlArrayItem("specificStaticSpeedProfileChange", Namespace = "https://erju.org/ato")]
		public List<SpecificStaticSpeedProfileChange>? specificStaticSpeedProfile;		
		[XmlAttribute]
		public uint speed;
		[XmlAttribute]
		public TrainEndApplicability trainEndApplicability;
	}
}