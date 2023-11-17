using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "aTO")]
	public class ATO
	{
		[XmlArrayItem("atoArea", Namespace = "https://erju.org/ato")]
		public List<ato.ATOArea> atoAreas;
	}
}