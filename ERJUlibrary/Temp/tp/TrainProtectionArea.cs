using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "trainProtectionArea")]
	public class TrainProtectionArea
	{		
		[XmlArrayItem("driveProtectionSectionGroup", Namespace = "https://erju.org/tp")]
		public List<DriveProtectionSectionGroup>? dpsGroups;		
		[XmlArrayItem("allocationSection", Namespace = "https://erju.org/tp")]
		public List<AllocationSection>? allocationSections;
	}
}