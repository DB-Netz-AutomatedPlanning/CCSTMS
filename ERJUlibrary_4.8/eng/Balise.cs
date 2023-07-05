using System.Xml.Serialization;
using System.Collections.Generic;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "balise")]
	public class Balise
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
                return this.id != null?  this.id : "";   
            }
        
        }			
		[XmlAttribute(AttributeName ="fixed")]
		public bool _fixed;		
		[XmlAttribute]
		public bool linked;		
		[XmlAttribute]
		public bool verticallyOriented;		
		[XmlAttribute]
		public bool standardSize;
		[XmlArrayItem("balisePacket", Namespace = "https://erju.org/eng")]
		public List<BalisePacket> etcsPackets;

    }
}
