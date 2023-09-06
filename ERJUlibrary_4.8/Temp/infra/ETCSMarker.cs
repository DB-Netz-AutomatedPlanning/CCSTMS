using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "eTCSMarker")]
	public class ETCSMarker
	{		
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

		public TrackEdge trackEdge;

        public uint pos;

        public bool sameDir;

        [XmlAttribute]
		public bool markerFunctionStop;
	}
}
