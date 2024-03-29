using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "voltageChange")]
	public class VoltageChange
	{		
		[XmlAttribute]
		public uint pos;		
		[XmlAttribute]
		public VoltageType voltage;		
		[XmlAttribute]
		public uint nidC;
	}
}
