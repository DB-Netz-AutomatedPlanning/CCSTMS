using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "axleLoadSpeedProfile")]
	public struct AxleLoadSpeedProfile
	{		
		[XmlAttribute]
		public uint startP;		
		[XmlAttribute]
		public uint endP;		
		[XmlAttribute]
		public uint speed;		
		[XmlAttribute]
public AxleLoadCategory axleLoadCategory;
	}
}