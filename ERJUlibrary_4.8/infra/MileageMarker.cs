using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "mileageMarker")]
	public class MileageMarker
	{		
		[XmlAttribute]
		public uint pos;		
		[XmlAttribute]
		public uint v;
	}
}
