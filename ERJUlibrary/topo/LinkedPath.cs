using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "linkedPath")]
	public struct LinkedPath
	{		
		public List<DirTrackEdge> dirTrackEdges;		
		[XmlAttribute]
		public uint skipFromStart;		
		[XmlAttribute]
		public uint skipFromEnd;
	}
}