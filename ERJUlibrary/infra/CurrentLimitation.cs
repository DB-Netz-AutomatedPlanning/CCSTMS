using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "currentLimitation")]
	public class CurrentLimitation
	{
        [XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/infra")]
        public List<TrackEdgeSection>? trackSections;		
		[XmlAttribute]
		public uint maxCurrent;
	}
}