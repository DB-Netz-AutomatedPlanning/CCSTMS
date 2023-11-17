using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "aTOArea")]
	public class ATOArea
	{
		[XmlArrayItem("segment", Namespace = "https://erju.org/ato")]
		public List<ato.ATOSegment> segments;
		[XmlArrayItem("timingPointsMappingItem", Namespace = "https://erju.org/ato")]
		public List<ato.TimingPointMapping> timingPointsMapping;
		[XmlAttribute]
		public string id {get;set;}
	}
}