using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "verticalLine")]
	public class VerticalLine
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public int slope;
	}
}