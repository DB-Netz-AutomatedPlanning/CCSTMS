using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "trackCondSelection")]
	public class TrackCondSelection
	{
		[XmlArrayItem("dlmCond", Namespace = "https://erju.org/ss026")]
		public List<DLMCondition> dlmConds;
		[XmlAttribute]
		public uint d_trackinit;

	}
}
