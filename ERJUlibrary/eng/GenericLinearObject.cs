using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "genericLinearObject")]
	public struct GenericLinearObject
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
		public List<string> trackEdgeSection;		
		private string trackEdgePoint;
		[XmlAttribute(AttributeName = "trackEdgePoint")]
		public string TrackEdgePoint
        {
            set
            {
                this.trackEdgePoint = value;
            }
            get
            {
                return this.trackEdgePoint != null ? this.trackEdgePoint : "";   
            }
        
        }		

		[XmlAttribute]
GenericLinearObjectType type;		
		[XmlAttribute]
		public uint lateralOffset;		
		[XmlAttribute]
		public uint length;
	}
}