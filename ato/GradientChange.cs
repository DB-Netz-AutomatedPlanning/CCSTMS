using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "gradientChange")]
	public class GradientChange
	{
		[XmlAttribute]
		public uint gradient {get;set;}
		[XmlAttribute]
		public bool uphillGradient {get;set;}
		[XmlAttribute]
		public uint pos {get;set;}
	}
}