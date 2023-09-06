using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "curveChange")]
	public class CurveChange
	{		
		[XmlAttribute]
		public CurveRadius curve;		
		[XmlAttribute]
		public uint p;
	}
}