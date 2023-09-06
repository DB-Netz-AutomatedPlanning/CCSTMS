using System.Xml.Serialization;
using System.Collections.Generic;
namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "driveProtectionSection")]
	public class DriveProtectionSection
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
		public infra.TrackEdgeSection trackEdgeSection;		
		[XmlAttribute]
        public infra.Direction flankProtectionDirection;		
		[XmlAttribute]
        public MinimalDrivability minimalDrivability;
	}
}
