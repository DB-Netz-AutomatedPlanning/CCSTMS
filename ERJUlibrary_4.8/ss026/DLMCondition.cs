using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "dLMCondition")]
	public class DLMCondition
	{
		[XmlAttribute]
		public uint d_trackcond;
		[XmlAttribute]
		public uint l_trackcond;
		[XmlAttribute]
		public TrackCondType m_trackcond;

	}
}
