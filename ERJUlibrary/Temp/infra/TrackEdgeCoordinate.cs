using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeCoordinate")]
	public class TrackEdgeCoordinate
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public double x;		
		[XmlAttribute]
		public double y;		
		[XmlAttribute]
		public double z;
	}
}