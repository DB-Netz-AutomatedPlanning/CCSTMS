using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "voltageStart")]
	public class VoltageStart
	{		
		[XmlAttribute]
		public VoltageType voltage;		
		[XmlAttribute]
		public uint nidC;
	}
}