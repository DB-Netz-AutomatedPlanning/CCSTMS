using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "mileageMarker")]
	public struct MileageMarker
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public uint v;
	}
}