using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "axleLoadSpeedProfile")]
	public class AxleLoadSpeedProfile
	{
		public ato.SegmentSection? segmentSection {get;set;}
		[XmlAttribute]
		public uint speed {get;set;}
		[XmlAttribute]
		public ato.TrainEndApplicability trainEndApplicability {get;set;}
		[XmlAttribute]
		public infra.AxleLoadCategory axleLoadCategory {get;set;}
	}
}