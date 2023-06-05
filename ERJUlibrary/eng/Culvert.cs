using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using topo;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "culvert")]
	public struct Culvert
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
		private string name;
		[XmlAttribute(AttributeName = "name")]
		public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name != null ? this.name : "";   
            }
        
        }		
		[XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/eng")]
		public List<TrackEdgeSection> trackEdgeSections;		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public uint length;		

		[XmlAttribute]
ConstructionMaterial material;
	}
}