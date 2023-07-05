using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "balise")]
	public class Balise
	{
        public TrackEdgePoint trackEdgePoint;
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
		public uint positionInGroup;		
	}
}
