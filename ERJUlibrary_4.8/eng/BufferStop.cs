using System.Xml.Serialization;
using System.Collections.Generic;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "bufferStop")]
	public class BufferStop
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
        [XmlArrayItem("dangerPoint", Namespace = "https://erju.org/eng")]
        public List<DangerPointRef> dangerPoints;
        [XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/infra")]
        public List<TrackEdgeSection> trackEdgeSections;
        [XmlAttribute]
        public BufferStopType bsType;
    }
}
