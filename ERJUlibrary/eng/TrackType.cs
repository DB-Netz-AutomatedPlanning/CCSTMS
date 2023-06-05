using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using topo;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "trackType")]
	public struct TrackType
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
		[XmlArrayItem("trackEdgePoint", Namespace = "https://erju.org/eng")]
		public List<TrackEdgePoint> trackEdgePoints;		

		[XmlAttribute]
RailwayTrackType rtType;
	}
}