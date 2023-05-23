using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "permittedBrakingDistance")]
	public struct PermittedBrakingDistance
	{		
		public List<TrackEdgeSection> trackSections;		
		[XmlAttribute]
		public uint brakeDist;
	}
}