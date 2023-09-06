using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeSpeedProfile")]
	public class TrackEdgeSpeedProfile
	{
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
        public bool sameDir;	

	}
}
