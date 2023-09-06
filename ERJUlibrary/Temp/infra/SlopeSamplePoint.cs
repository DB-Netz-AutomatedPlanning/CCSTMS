using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "slopeSamplePoint")]
	public class SlopeSamplePoint
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public int s;
	}
}