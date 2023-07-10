using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "cantSamplePoint")]
	public class CantSamplePoint
	{		
		[XmlAttribute]
		public uint p;				
		[XmlAttribute]
		public int c;
	}
}