using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "mileageMarker")]
	public class MileageMarker
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public uint v;
	}
}