using System.Xml.Serialization;
using System.Collections.Generic;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "trackEdgeMileage")]
	public class TrackEdgeMileage
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
	
		[XmlArrayItem("mileagePoint", Namespace = "https://erju.org/eng")]
		public List<MileagePoint> points;
    }
}
