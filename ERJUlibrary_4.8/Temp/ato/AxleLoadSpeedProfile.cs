using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "axleLoadSpeedProfile")]
	public class AxleLoadSpeedProfile
	{		
		public SegmentSection segmentSection;		
		[XmlAttribute]
		public uint speed;		
		[XmlAttribute]
		public TrainEndApplicability trainEndApplicability;		
		[XmlAttribute]
        public infra.AxleLoadCategory axleLoadCategory;
	}
}
