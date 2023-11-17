using System.Xml.Serialization;
using System.Collections.Generic;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "mileageReferenceMarker")]
	public class MileageReferenceMarker
	{
		[XmlAttribute]
		public string name {get;set;}
		[XmlAttribute]
		public double mileage {get;set;}
		[XmlAttribute]
		public string trackEdge {get;set;}
		[XmlAttribute]
		public double pos {get;set;}
	}
}