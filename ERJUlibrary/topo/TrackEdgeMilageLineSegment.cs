using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "trackEdgeMilageLineSegment")]
	public struct TrackEdgeMilageLineSegment
	{		
		private string trackEdge;
		[XmlAttribute(AttributeName = "trackEdge")]
		public string TrackEdge
        {
            set
            {
                this.trackEdge = value;
            }
            get
            {
                return this.trackEdge != null ? this.trackEdge : "";   
            }
        
        }		
		public MilageMarker points;
	}
}