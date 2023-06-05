using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "trackBed")]
	public struct TrackBed
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
BallastType ballast;		

		[XmlAttribute]
JointType joint;		

		[XmlAttribute]
RailType rail;
	}
}