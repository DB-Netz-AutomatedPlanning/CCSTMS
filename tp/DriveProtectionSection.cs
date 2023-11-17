using System.Xml.Serialization;
using System.Collections.Generic;

namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "driveProtectionSection")]
	public class DriveProtectionSection
	{
		public infra.TrackEdgeSection? trackEdgeSection {get;set;}
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string name {get;set;}
		[XmlAttribute]
		public infra.Direction flankProtectionDirection {get;set;}
	}
}