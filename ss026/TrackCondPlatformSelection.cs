using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "trackCondPlatformSelection")]
	public class TrackCondPlatformSelection
	{
		[XmlArrayItem("tcspCond", Namespace = "https://erju.org/ss026")]
		public List<ss026.TCSPCondition> tcspConds;
		public D_trackinitRef? d_trackinit {get;set;}
	}
}