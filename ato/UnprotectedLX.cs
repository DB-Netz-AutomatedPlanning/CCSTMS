using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "unprotectedLX")]
	public class UnprotectedLX
	{
		[XmlAttribute]
		public uint pNominal {get;set;}
		[XmlAttribute]
		public uint pReverse {get;set;}
	}
}