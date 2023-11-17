using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "dLMCondition")]
	public class DLMCondition
	{
		[XmlAttribute]
		public uint d_trackcond {get;set;}
		[XmlAttribute]
		public uint l_trackcond {get;set;}
		[XmlAttribute]
		public ss026.TrackCondType m_trackcond {get;set;}
	}
}