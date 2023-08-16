using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "mpTargetMarker")]
	public class MpTargetMarker
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
        public uint pos;
        [XmlAttribute]
        public MpTargetMarkerType type;
	}
}
