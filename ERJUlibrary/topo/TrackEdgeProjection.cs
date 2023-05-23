using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "trackEdgeProjection")]
	public struct TrackEdgeProjection
	{		
		[XmlAttribute]
		private string trackEdgeId;
		[XmlAttribute(AttributeName = "trackEdgeId")]
		public string TrackEdgeId
        {
            set
            {
                this.trackEdgeId = value;
            }
            get
            {
                return this.trackEdgeId != null ? this.trackEdgeId : "";   
            }
        
        }		
		public List<TrackEdgeCoordinate> coordinates;
	}
}