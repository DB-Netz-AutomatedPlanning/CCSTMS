using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "balise")]
	public struct Balise
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
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public uint numberOfBalisesInGroup;		
		[XmlAttribute]
		public bool _fixed;		
		[XmlAttribute]
		public bool linked;		
		[XmlAttribute]
		public bool verticallyOriented;		
		[XmlAttribute]
		public bool standardSize;		
		[XmlAttribute]
        ETCSlevel level;		
		[XmlAttribute]
		public uint packetNumber;		
		private string baliseGroup;
		[XmlAttribute(AttributeName = "baliseGroup")]
		public string BaliseGroup
        {
            set
            {
                this.baliseGroup = value;
            }
            get
            {
                return this.baliseGroup != null ? this.baliseGroup : "";   
            }
        
        }
	}
}