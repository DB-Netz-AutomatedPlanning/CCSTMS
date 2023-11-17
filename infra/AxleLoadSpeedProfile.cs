using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "axleLoadSpeedProfile")]
	public class AxleLoadSpeedProfile
	{
		[XmlAttribute]
		public uint startPos {get;set;}
		[XmlAttribute]
		public uint endPos {get;set;}
		[XmlAttribute]
		public uint speed {get;set;}
		[XmlAttribute]
		public infra.AxleLoadCategory axleLoadCategory {get;set;}
	}
}