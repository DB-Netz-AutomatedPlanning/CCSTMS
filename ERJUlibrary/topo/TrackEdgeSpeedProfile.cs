using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "trackEdgeSpeedProfile")]
	public struct TrackEdgeSpeedProfile
	{		
		[XmlAttribute]
		private string id;
		[XmlAttribute(AttributeName = "id")]
		public string Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id != null ? this.id : "";   
            }
        
        }		
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
		[XmlArrayItem("staticSpeedLimit", Namespace = "https://erju.org/topo")]
		public List<StaticSpeedLimit> staticSpeedProfile;		
		[XmlArrayItem("axleLoadSpeedProfile", Namespace = "https://erju.org/topo")]
		public List<AxleLoadSpeedProfile> axleLoadSpeedProfiles;		
		[XmlAttribute]
        public Direction direction;
	}
}