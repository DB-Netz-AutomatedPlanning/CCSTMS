using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "unprotectedLX")]
	public class UnprotectedLX
	{		
		[XmlAttribute]
		public uint pNominal;		
		[XmlAttribute]
		public uint pReverse;
	}
}