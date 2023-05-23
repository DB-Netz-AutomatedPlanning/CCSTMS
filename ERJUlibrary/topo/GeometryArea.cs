using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "geometryArea")]
	public struct GeometryArea
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
                return this.id != null ? this.id : "";   
            }
        
        }		
		[XmlAttribute]
		public bool alignment3d;		
		public List<TrackEdgeGeometry> trackEdgeGeometries;		
		public List<SampledTrackEdgeGeometry> sampledTrackEdgeGeometries;
	}
}