using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeProjection")]
	public class TrackEdgeProjection
	{		
		[XmlAttribute]
		private string trackEdgeId;
		[XmlAttribute(AttributeName = "trackEdgeId")]
		public string TrackEdgeId
        {
            set
            {
                this.trackEdgeId = value;
            }
            get
            {
                return this.trackEdgeId != null?  this.trackEdgeId : "";   
            }
        
        }
        [XmlArrayItem("coordinate", Namespace = "https://erju.org/infra")]
        public List<TrackEdgeCoordinate> coordinates;
	}
}
