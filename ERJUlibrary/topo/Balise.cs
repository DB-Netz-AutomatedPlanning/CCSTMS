using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "balise")]
	public struct Balise
	{		
		public TrackEdgePoint trackEdgePoint;		
		[XmlAttribute]
		public uint positionInGroup;		
		[XmlAttribute]
		private string baliseTelegram;
		[XmlAttribute(AttributeName = "baliseTelegram")]
		public string BaliseTelegram
        {
            set
            {
                this.baliseTelegram = value;
            }
            get
            {
                return this.baliseTelegram != null ? this.baliseTelegram : "";   
            }
        
        }
	}
}