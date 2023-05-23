using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "cantSamplePoint")]
	public struct CantSamplePoint
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public int cant;		
		[XmlAttribute]
		public int c;
	}
}