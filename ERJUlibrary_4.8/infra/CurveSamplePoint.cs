using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "curveSamplePoint")]
	public class CurveSamplePoint
	{		
		[XmlAttribute]
		public uint pos;		
		[XmlAttribute]
		public int r;
	}
}
