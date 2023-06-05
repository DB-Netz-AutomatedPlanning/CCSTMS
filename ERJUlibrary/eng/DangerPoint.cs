using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using topo;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "dangerPoint")]
	public struct DangerPoint
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
		private string position;
		[XmlAttribute(AttributeName = "position")]
		public string Position
        {
            set
            {
                this.position = value;
            }
            get
            {
                return this.position != null ? this.position : "";   
            }
        
        }		
		[XmlAttribute]
		public uint p;		
		public TrackEdgePoint trackEdgePoints;		
		[XmlAttribute]
		public uint allowableApproachingSpeed;
	}
}