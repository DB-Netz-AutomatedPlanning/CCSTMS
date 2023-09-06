using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using infra;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "sleepers")]
	public class Sleepers
	{		
		[XmlAttribute]
		private string? id;
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
        [XmlArrayItem("trackEdgeSection", Namespace = "https://erju.org/infra")]
        public List<TrackEdgeSection>? trackEdgeSection;
        [XmlAttribute]
		public SleepersType type;
	}
}