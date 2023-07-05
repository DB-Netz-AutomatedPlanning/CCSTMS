using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "driveProtectionSectionGroup")]
	public class DriveProtectionSectionGroup
	{		
		[XmlAttribute]
		private string? id;
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
		private string? name;
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
		[XmlArrayItem("driveProtectionSection", Namespace = "https://erju.org/tp")]
		public List<DriveProtectionSection>? driveProtectionSections;		
		[XmlArrayItem("protectedInfraElement", Namespace = "https://erju.org/tp")]
		public List<ProtectedInfraElement>? protectedInfraElements;
	}
}