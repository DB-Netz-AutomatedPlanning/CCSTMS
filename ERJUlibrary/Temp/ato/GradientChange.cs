using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "gradientChange")]
	public class GradientChange
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public bool uphillGradient;
	}
}