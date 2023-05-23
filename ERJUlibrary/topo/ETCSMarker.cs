using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "eTCSMarker")]
	public struct ETCSMarker
	{		
		[XmlAttribute]
		public uint id;		
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
		public TrackEdgePoint trackEdgePoint;		
		[XmlAttribute]
		public bool markerFunctionStop;
	}
}