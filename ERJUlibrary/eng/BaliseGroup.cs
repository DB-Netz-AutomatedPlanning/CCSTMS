using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "baliseGroup")]
	public struct BaliseGroup
	{
        [XmlAttribute]
        private string dpTyp;
        [XmlAttribute(AttributeName = "dpTyp")]
        public string DPTyp
        {
            set
            {
                this.dpTyp = value;
            }
            get
            {
                return this.dpTyp != null ? this.dpTyp : "";
            }

        }
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
		public List<string> trackEdges;		
		[XmlAttribute]
		private string regionIdentifier;
		[XmlAttribute(AttributeName = "regionIdentifier")]
		public string RegionIdentifier
        {
            set
            {
                this.regionIdentifier = value;
            }
            get
            {
                return this.regionIdentifier != null ? this.regionIdentifier : "";   
            }
        
        }		
		[XmlAttribute]
		public uint identityNumber;
	}
}