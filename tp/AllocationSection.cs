using System.Xml.Serialization;
using System.Collections.Generic;

namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "allocationSection")]
	public class AllocationSection
	{
		[XmlElement(Order = 0 )]
		public infra.LinkedPath? linearLocation {get;set;}
		[XmlArrayItem("allocationSection", Namespace = "https://erju.org/tp"), XmlArray(Order =1)]
		public List<AllocationSectionRef> allocationSections;
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string name {get;set;}
	}
}