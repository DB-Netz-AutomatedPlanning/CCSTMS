using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "trackEdgeCoordinate")]
	public struct TrackEdgeCoordinate
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