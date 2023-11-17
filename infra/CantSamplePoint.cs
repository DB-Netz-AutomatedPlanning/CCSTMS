using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "cantSamplePoint")]
	public class CantSamplePoint
	{
		[XmlAttribute]
		public uint pos {get;set;}
		[XmlAttribute]
		public double appliedCant {get;set;}
		[XmlAttribute]
		public int cant {get;set;}
	}
}