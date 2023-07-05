using eng;
using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "permittedBrakingDistance")]
	public class PermittedBrakingDistance
	{
        [XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/infra")]
        public List<TrackEdgeSection>? trackSections;		
        [XmlAttribute]
        public uint pbdDist;
        [XmlAttribute]
        public int pbdGradient;
        [XmlAttribute]
        public BreakType brakeType;
    }
}