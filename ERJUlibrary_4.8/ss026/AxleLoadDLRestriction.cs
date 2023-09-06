using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "axleLoadDLRestriction")]
	public class AxleLoadDLRestriction
	{
		[XmlAttribute]
		public uint d_axleload_k;
		[XmlAttribute]
		public uint l_axleload_k;
		[XmlAttribute]
		public bool q_front_k;
		[XmlArrayItem("restriction", Namespace = "https://erju.org/ss026")]
		public List<AxleLoadRestriction> restrictions;

	}
}
