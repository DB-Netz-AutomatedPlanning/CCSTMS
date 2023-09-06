using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "curveSamplePoint")]
	public class CurveSamplePoint
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public int r;
	}
}