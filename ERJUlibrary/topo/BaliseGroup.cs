using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "baliseGroup")]
	public struct BaliseGroup
	{

 
        public List<Balise> balises;
        [XmlAttribute]
        public BaliseGroupFunction bgFunction;
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
		public uint nidBG;		
		[XmlAttribute]
		public uint nidC;		
		
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
		public uint locationAccuracy;
	}
}