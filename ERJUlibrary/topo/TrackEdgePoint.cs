using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "trackEdgePoint")]
	public struct TrackEdgePoint
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
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public int lateralOffset;
	}
}