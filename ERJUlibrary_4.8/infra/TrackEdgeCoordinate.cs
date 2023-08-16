using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeCoordinate")]
	public class TrackEdgeCoordinate
	{		
		[XmlAttribute]
		public uint pos;		
		[XmlAttribute]
		public double x;		
		[XmlAttribute]
		public double y;		
		[XmlAttribute]
		public double z;
	}
}
