using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "trackCondPlatformSelection")]
	public class TrackCondPlatformSelection
	{
		[XmlArrayItem("tcspCond", Namespace = "https://erju.org/ss026")]
		public List<TCSPCondition> tcspConds;
		[XmlAttribute]
		public uint d_trackinit;

	}
}
