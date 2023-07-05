using infra;
using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "eTCSMarker")]
	public class ETCSMarker
	{		
		[XmlAttribute]
		private string? id;
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
		private string? name;
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
		public DirTrackEdgePoint? dirTrackEdgePoint;		
		[XmlAttribute]
		public bool markerFunctionStop;
	}
}