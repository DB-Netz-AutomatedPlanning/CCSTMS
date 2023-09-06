using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "currentStart")]
	public class CurrentStart
	{		
		[XmlAttribute]
		public uint current;
	}
}
