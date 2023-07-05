using System.Xml.Serialization;
using System.Collections.Generic;
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
