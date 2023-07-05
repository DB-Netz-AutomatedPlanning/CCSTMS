using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "geometryArea")]
	public class GeometryArea
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
		[XmlAttribute]
		public bool alignment3d;
        [XmlArrayItem("trackEdgeGeometry", Namespace = "https://erju.org/infra")]
        public List<TrackEdgeGeometry>? trackEdgeGeometries;
        [XmlArrayItem("sampledTrackEdgeGeometry", Namespace = "https://erju.org/infra")]
        public List<SampledTrackEdgeGeometry>? sampledTrackEdgeGeometries;
	}
}