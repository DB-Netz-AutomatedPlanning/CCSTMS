using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "axleLoadSpeedProfile")]
	public class AxleLoadSpeedProfile
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