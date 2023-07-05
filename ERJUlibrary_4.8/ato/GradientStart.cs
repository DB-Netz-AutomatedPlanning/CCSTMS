using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "gradientStart")]
	public class GradientStart
	{		
		[XmlAttribute]
		public uint gradient;		
		[XmlAttribute]
		public bool uphillGradient;
	}
}
