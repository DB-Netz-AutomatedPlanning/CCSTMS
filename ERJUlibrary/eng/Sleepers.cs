using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using topo;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "sleepers")]
	public struct Sleepers
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
		public TrackEdgePoint trackEdgePoints;		
		[XmlAttribute]
		public uint p;		

		[XmlAttribute]
SleepersType sleepersType;
	}
}