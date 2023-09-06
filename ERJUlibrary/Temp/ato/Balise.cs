using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "balise")]
	public class Balise
	{		
		[XmlAttribute]
		public uint positionInGroup;		
		[XmlAttribute]
		public uint p;
	}
}