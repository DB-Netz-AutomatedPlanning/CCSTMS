using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "operationalPoint")]
	public class OperationalPoint
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
        [XmlArrayItem("timingPoint", Namespace = "https://erju.org/infra")]
        public List<TimingPointRef> timingPoints;
        [XmlAttribute]
        public OPType type;
        [XmlArrayItem("platform", Namespace = "https://erju.org/infra")]
        public List<Platform> platforms;
	}
}
