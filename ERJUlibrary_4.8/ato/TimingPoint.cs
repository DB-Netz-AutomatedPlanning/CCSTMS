using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "timingPoint")]
	public class TimingPoint
	{		
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
                return this.name != null?  this.name : "";   
            }
        
        }		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public uint nidTP;		
		[XmlAttribute]
		public uint stopLocationTolerance;		
		[XmlAttribute]
		public uint stoppingPointReachDistance;
	}
}
