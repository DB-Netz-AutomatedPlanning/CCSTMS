using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_67")]
	public class ETCSPacket_67
	{
		[XmlArrayItem("trackCondition", Namespace = "https://erju.org/ss026")]
		public List<DLTrackCond> trackConditions;

	}
}
