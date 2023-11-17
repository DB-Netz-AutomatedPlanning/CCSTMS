using System.Xml.Serialization;
using System.Collections.Generic;

namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "trainProtectionArea")]
	public class TrainProtectionArea
	{
		[XmlArrayItem("dpsGroup", Namespace = "https://erju.org/tp")]
		public List<tp.DriveProtectionSectionGroup> dpsGroups;
		[XmlArrayItem("allocationSection", Namespace = "https://erju.org/tp")]
		public List<tp.AllocationSection> allocationSections;
		[XmlAttribute]
		public string id {get;set;}
	}
}