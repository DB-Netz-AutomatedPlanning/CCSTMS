using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeSpeedProfile")]
	public class TrackEdgeSpeedProfile
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
		[XmlArrayItem("staticSpeedLimit", Namespace = "https://erju.org/infra")]
		public List<StaticSpeedLimit> staticSpeedProfile;		
		[XmlArrayItem("axleLoadSpeedProfile", Namespace = "https://erju.org/infra")]
		public List<AxleLoadSpeedProfile> axleLoadSpeedProfiles;		
		[XmlAttribute]
        public Direction direction;
	}
}
