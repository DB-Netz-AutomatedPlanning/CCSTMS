using System.Xml.Serialization;
using System.Collections.Generic;

namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "driveProtectionSectionGroup")]
	public class DriveProtectionSectionGroup
	{
		[XmlArrayItem("driveProtectionSection", Namespace = "https://erju.org/tp")]
		public List<tp.DriveProtectionSection> driveProtectionSections;
		public tp.ProtectedInfraElement? protectedInfraElements {get;set;}
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string name {get;set;}
		[XmlAttribute]
		public tp.DPSDependencyType dependenciesType {get;set;}
		[XmlAttribute]
		public List<uint> dependencies {get;set;}
	}
}