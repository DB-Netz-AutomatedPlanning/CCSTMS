using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "atoTSContactInfo")]
	public class AtoTSContactInfo
	{		
		[XmlAttribute]
		public uint nidATOTS;		
		[XmlAttribute]
		public uint nidSP;		
		[XmlAttribute]
		public uint spNidC;		
		[XmlAttribute]
		public uint atotsNidC;
	}
}
