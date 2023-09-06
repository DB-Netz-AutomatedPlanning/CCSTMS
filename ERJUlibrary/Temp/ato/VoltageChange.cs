using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "voltageChange")]
	public class VoltageChange
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public VoltageType voltage;		
		[XmlAttribute]
		public uint nidC;
	}
}