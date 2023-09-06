using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "aTO")]
	public class ATO
	{		
		[XmlArrayItem("aTOArea", Namespace = "https://erju.org/ato")]
		public List<ATOArea>? atoAreas;
	}
}