using System.Xml.Serialization;
using System.Collections.Generic;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "mileageReferenceMarker")]
	public class MileageReferenceMarker
	{
		[XmlAttribute]
		public uint pos;
		[XmlAttribute]
		public uint mileage;


		private string trackEdge;
		[XmlAttribute(AttributeName = "TrackEdge")]
		public string TrackEdge
        {
            set
            {
                this.trackEdge = value;
            }
            get
            {
                return this.trackEdge != null?  this.trackEdge : "";   
            }
        
        }

		private string name;
		[XmlAttribute(AttributeName = "Name")]
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

    }
}
