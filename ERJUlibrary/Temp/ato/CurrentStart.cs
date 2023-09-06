using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "currentStart")]
	public class CurrentStart
	{		
		[XmlAttribute]
		public uint current;
	}
}