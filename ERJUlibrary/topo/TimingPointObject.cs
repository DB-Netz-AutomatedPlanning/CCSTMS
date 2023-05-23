using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "timingPointObject")]
	public struct TimingPointObject
	{		
		private string etcsMarkerBoard;
		[XmlAttribute(AttributeName = "etcsMarkerBoard")]
		public string EtcsMarkerBoard
        {
            set
            {
                this.etcsMarkerBoard = value;
            }
            get
            {
                return this.etcsMarkerBoard != null ? this.etcsMarkerBoard : "";   
            }
        
        }		
		private string platform;
		[XmlAttribute(AttributeName = "platform")]
		public string Platform
        {
            set
            {
                this.platform = value;
            }
            get
            {
                return this.platform != null ? this.platform : "";   
            }
        
        }		
		private string stopLocation;
		[XmlAttribute(AttributeName = "stopLocation")]
		public string StopLocation
        {
            set
            {
                this.stopLocation = value;
            }
            get
            {
                return this.stopLocation != null ? this.stopLocation : "";   
            }
        
        }
	}
}