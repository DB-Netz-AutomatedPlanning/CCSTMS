using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "topoArea")]
	public class TopoArea
	{		
		[XmlAttribute]
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
        [XmlArrayItem("trackEdge", Namespace = "https://erju.org/infra")]
        public List<TrackEdge>? trackEdges;
        [XmlArrayItem("trackEdgeLink", Namespace = "https://erju.org/infra")]
        public List<TrackEdgeLink>? trackEdgeLinks;
	}
}