using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "atoTSContactInfo")]
	public class AtoTSContactInfo
	{
		[XmlAttribute]
		public uint nidATOTS {get;set;}
		[XmlAttribute]
		public uint nidSP {get;set;}
		[XmlAttribute]
		public uint spNidC {get;set;}
		[XmlAttribute]
		public uint atotsNidC {get;set;}
	}
}