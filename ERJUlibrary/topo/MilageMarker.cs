using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "milageMarker")]
	public struct MilageMarker
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public uint v;
	}
}