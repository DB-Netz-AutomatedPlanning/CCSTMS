using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
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