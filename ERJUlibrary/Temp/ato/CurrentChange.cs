using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "currentChange")]
	public class CurrentChange
	{		
		[XmlAttribute]
		public uint p;		
		[XmlAttribute]
		public uint current;
	}
}