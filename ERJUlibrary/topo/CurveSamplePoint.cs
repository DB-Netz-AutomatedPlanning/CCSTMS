using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "curveSamplePoint")]
	public struct CurveSamplePoint
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public int r;
	}
}