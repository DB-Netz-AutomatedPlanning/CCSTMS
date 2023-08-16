using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeMileageLineSegment")]
	public class TrackEdgeMileageLineSegment
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
		public MileageMarker points;
	}
}
