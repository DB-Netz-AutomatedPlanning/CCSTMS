using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "trackEdgeLink")]
	public struct TrackEdgeLink
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
		private string trackEdgeA;
		[XmlAttribute(AttributeName = "trackEdgeA")]
		public string TrackEdgeA
        {
            set
            {
                this.trackEdgeA = value;
            }
            get
            {
                return this.trackEdgeA != null ? this.trackEdgeA : "";   
            }
        
        }		
		private string trackEdgeB;
		[XmlAttribute(AttributeName = "trackEdgeB")]
		public string TrackEdgeB
        {
            set
            {
                this.trackEdgeB = value;
            }
            get
            {
                return this.trackEdgeB != null ? this.trackEdgeB : "";   
            }
        
        }		
		[XmlAttribute]
		public bool startOnA;		
		[XmlAttribute]
		public bool startOnB;
	}
}