using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "permittedBrakingDistance")]
	public class PermittedBrakingDistance
	{
		[XmlArrayItem("trackSection", Namespace = "https://erju.org/infra")]
		public List<infra.TrackEdgeSection> trackSections;
		[XmlAttribute]
		public uint pbdDist {get;set;}
		[XmlAttribute]
		public infra.BrakeType brakeType {get;set;}
		[XmlAttribute]
		public int pbdGradient {get;set;}
		[XmlAttribute]
		public bool sameDir {get;set;}
	}
}