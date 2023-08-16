using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "curveChange")]
	public class CurveChange
	{		
		[XmlAttribute]
		public CurveRadius curve;		
		[XmlAttribute]
		public uint pos;
	}
}
