using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "curveStart")]
	public class CurveStart
	{		
		[XmlAttribute]
		public CurveRadius curve;
	}
}