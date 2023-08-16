using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "horizontalTransition")]
	public class HorizontalTransition
	{		
		[XmlAttribute]
		public uint pos;		
		[XmlAttribute]
		public uint azimuth;		
		[XmlAttribute]
		public int radius;
        [XmlAttribute]
        public TransitionType type;
	}
}
