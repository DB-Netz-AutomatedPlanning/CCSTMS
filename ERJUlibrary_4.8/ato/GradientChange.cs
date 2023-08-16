using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "gradientChange")]
	public class GradientChange
	{		
		[XmlAttribute]
		public uint pos;		
		[XmlAttribute]
		public bool uphillGradient;
	}
}
