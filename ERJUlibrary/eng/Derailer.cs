using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using topo;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "derailer")]
	public struct Derailer
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
		[XmlAttribute]
		private string name;
		[XmlAttribute(AttributeName = "name")]
		public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name != null ? this.name : "";   
            }
        
        }		
		private string positionRef;
		[XmlAttribute(AttributeName = "positionRef")]
		public string PositionRef
        {
            set
            {
                this.positionRef = value;
            }
            get
            {
                return this.positionRef != null ? this.positionRef : "";   
            }
        
        }		
		[XmlAttribute]
		public uint p;		
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
TrackSide derailerSide;		

		[XmlAttribute]
Direction direction;
	}
}