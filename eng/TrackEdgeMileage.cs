using System.Xml.Serialization;
using System.Collections.Generic;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "trackEdgeMileage")]
	public class TrackEdgeMileage
	{
		[XmlArrayItem("point", Namespace = "https://erju.org/eng")]
		public List<eng.MileagePoint> points;
		[XmlAttribute]
		public string id {get;set;}
	}
}