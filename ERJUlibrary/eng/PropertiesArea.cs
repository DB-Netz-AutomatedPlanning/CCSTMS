using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "propertiesArea")]
	public struct PropertiesArea
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
		public uint maximumLoadPerAxle;		
		[XmlAttribute]
		public uint maximumLoadPerMeter;		
		[XmlAttribute]
		public uint maximumAllowedSpeed;		
		public TrackBed trackBed;		
		public TrackType tracktype;		
		public Sleepers sleepers;
	}
}