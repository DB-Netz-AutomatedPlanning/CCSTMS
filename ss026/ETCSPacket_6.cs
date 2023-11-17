using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_6")]
	public class ETCSPacket_6
	{
		public ss026.ValidityPeriod? validityPeriod {get;set;}
		[XmlAttribute]
		public uint nid_c {get;set;}
	}
}