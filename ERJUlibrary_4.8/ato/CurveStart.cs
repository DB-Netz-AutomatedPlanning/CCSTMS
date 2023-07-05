using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "curveStart")]
	public class CurveStart
	{		
		[XmlAttribute]
		public CurveRadius curve;
	}
}
