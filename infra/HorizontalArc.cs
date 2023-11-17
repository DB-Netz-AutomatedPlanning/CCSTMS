using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "horizontalArc")]
	public class HorizontalArc
	{
		[XmlAttribute]
		public double pos {get;set;}
		[XmlAttribute]
		public double azimuth {get;set;}

        [XmlAttribute]
        public double radius { get; set; }
    }
}