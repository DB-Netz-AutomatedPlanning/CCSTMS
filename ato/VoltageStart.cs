using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "voltageStart")]
	public class VoltageStart
	{
		[XmlAttribute]
		public ato.VoltageType voltage {get;set;}
		[XmlAttribute]
		public uint nidC {get;set;}
	}
}