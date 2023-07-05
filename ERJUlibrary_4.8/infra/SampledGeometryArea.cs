using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "sampledGeometryArea")]
	public class SampledGeometryArea
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
        [XmlArrayItem("sampledTrackEdgeGeometry", Namespace = "https://erju.org/infra")]
        public List<SampledTrackEdgeGeometry> sampledTrackEdgeGeometries;
	}
}
