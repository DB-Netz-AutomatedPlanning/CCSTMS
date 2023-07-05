using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "unprotectedLX")]
	public class UnprotectedLX
	{		
		[XmlAttribute]
		public uint pNominal;		
		[XmlAttribute]
		public uint pReverse;
	}
}
