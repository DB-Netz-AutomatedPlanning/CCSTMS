using System.Xml.Serialization;
using System.Collections.Generic;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "baliseGroup")]
	public class BaliseGroup
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


		[XmlAttribute]
        public bool q_link;

		[XmlAttribute]
        public ETCSVersion m_version;

    }
}
