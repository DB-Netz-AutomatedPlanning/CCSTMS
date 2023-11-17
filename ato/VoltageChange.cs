using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "voltageChange")]
	public class VoltageChange
	{
		[XmlAttribute]
		public uint pos {get;set;}
		[XmlAttribute]
		public ato.VoltageType voltage {get;set;}
		[XmlAttribute]
		public uint nidC {get;set;}
	}
}