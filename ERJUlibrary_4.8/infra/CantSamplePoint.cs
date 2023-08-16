using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "cantSamplePoint")]
	public class CantSamplePoint
	{		
		[XmlAttribute]
		public uint pos;		
		[XmlAttribute]
		public int c;
        [XmlAttribute]
        public int cant;
    }
}
