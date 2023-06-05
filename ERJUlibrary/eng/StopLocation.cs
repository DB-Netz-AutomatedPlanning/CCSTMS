using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "stopLocation")]
	public struct StopLocation
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
		private string positionRef;
		[XmlAttribute(AttributeName = "positionRef")]
		public string PositionRef
        {
            set
            {
                this.positionRef = value;
            }
            get
            {
                return this.positionRef != null ? this.positionRef : "";   
            }
        
        }		

		[XmlAttribute]
StopLocationFunction function;		
		[XmlAttribute]
		private string value;
		[XmlAttribute(AttributeName = "value")]
		public string Value
        {
            set
            {
                this.value = value;
            }
            get
            {
                return this.value != null ? this.value : "";   
            }
        
        }
	}
}