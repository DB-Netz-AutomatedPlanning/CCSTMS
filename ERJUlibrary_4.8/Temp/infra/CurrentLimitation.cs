using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "currentLimitation")]
	public class CurrentLimitation
	{
        [XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/infra")]
        public List<TrackEdgeSection> trackSections;		
		[XmlAttribute]
		public uint maxCurrent;
	}
}
