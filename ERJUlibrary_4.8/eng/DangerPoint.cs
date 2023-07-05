using System.Xml.Serialization;
using System.Collections.Generic;
using infra;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "dangerPoint")]
	public class DangerPoint
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
                return this.id != null?  this.id : "";   
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
                return this.name != null?  this.name : "";   
            }
        
        }			
		public TrackEdgePoint trackEdgePoint;		
	}
}
