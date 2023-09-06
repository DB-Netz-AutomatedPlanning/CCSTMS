using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "tCSPCondition")]
	public class TCSPCondition
	{
		[XmlAttribute]
		public uint d_trackcond;
		[XmlAttribute]
		public uint l_trackcond;
		[XmlAttribute]
		public PlatformType m_platform;
		[XmlAttribute]
		public PlatformPosition q_platform;

	}
}
