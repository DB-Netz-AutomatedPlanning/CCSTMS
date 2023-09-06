using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "axleLoadSelection")]
	public class AxleLoadSelection
	{
				public AxleLoad axleLoad;
		[XmlAttribute]
		public uint d_trackinit;

	}
}
