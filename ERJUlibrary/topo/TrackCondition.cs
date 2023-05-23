using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "trackCondition")]
	public struct TrackCondition
	{		
		public List<TrackEdgeSection> trackSections;
        [XmlAttribute]
        public ConditionType type;
	}
}