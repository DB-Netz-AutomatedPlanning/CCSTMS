using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "baliseGroup")]
	public class BaliseGroup
	{

        [XmlArrayItem("balise", Namespace = "https://erju.org/infra")]
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
                return this.id != null?  this.id : "";   
            }
        
        }		
		[XmlAttribute]
		public uint nidBG;		
		[XmlAttribute]
		public uint nidC;		
				
		[XmlAttribute]
		public uint locationAccuracy;
	}
}
