using System.Xml.Serialization;
using System.Collections.Generic;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "mileageLine")]
	public class MileageLine
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
        [XmlElement(ElementName = "trackEdges")]
        public TrackEdgeMileage trackEdges;
        [XmlElement(ElementName = "horizontalSegment")]
        public infra.HorizontalSegment horizontalGeometry;
        [XmlElement(ElementName = "mileageReferenceMarker")]
        public MileageReferenceMarker referenceMarkers;
	}
}
