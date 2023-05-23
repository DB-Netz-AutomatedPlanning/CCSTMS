using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "slopeSamplePoint")]
	public struct SlopeSamplePoint
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public int s;
	}
}