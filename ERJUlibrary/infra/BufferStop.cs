using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "bufferStop")]
	public class BufferStop
	{
        private string? id;
        [XmlAttribute(AttributeName = "id")]
        public string Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id != null ? this.id : "";
            }

        }
        public TrackEdgePoint? trackEdgePoint;	
	}
}