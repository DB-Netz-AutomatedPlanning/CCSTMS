using System.Xml.Serialization;
using System.Collections.Generic;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "sleepers")]
	public class Sleepers
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
        [XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/infra")]
        public List<infra.TrackEdgeSection> trackEdgeSection;
        [XmlAttribute]
		public SleepersType type;
	}
}
