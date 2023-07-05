using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "bufferStop")]
	public class BufferStop
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
        public TrackEdgePoint trackEdgePoint;	
	}
}
