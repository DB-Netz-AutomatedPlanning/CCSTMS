using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeCoordinate")]
	public class TrackEdgeCoordinate
	{
		[XmlAttribute]
		public uint pos {get;set;}
		[XmlAttribute]
		public double x {get;set;}
		[XmlAttribute]
		public double y {get;set;}
		[XmlAttribute]
		public double z {get;set;}
	}
}