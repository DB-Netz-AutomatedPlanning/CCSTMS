using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "axleLoadRestriction")]
	public class AxleLoadRestriction
	{
		[XmlAttribute]
		public AxleLoadCategory m_axleloadcat_n;
		[XmlAttribute]
		public uint v_axleload_n;

	}
}
