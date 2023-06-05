using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using topo;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "markerBoard")]
	public struct MarkerBoard
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

		//[XmlAttribute]
        //public MarkerBoardType markerType;		
		[XmlAttribute]
		public uint p;		

		[XmlAttribute]
        public Direction direction;		
		private string tvps;
		[XmlAttribute(AttributeName = "tvps")]
		public string Tvps
        {
            set
            {
                this.tvps = value;
            }
            get
            {
                return this.tvps != null ? this.tvps : "";   
            }
        
        }
	}
}