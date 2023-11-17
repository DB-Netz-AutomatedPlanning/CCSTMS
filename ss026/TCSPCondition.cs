using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "tCSPCondition")]
	public class TCSPCondition
	{
		[XmlAttribute]
		public uint d_trackcond {get;set;}
		[XmlAttribute]
		public uint l_trackcond {get;set;}
		[XmlAttribute]
		public ss026.PlatformType m_platform {get;set;}
		[XmlAttribute]
		public ss026.PlatformPosition q_platform {get;set;}
	}
}