using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "axleLoadDLRestriction")]
	public class AxleLoadDLRestriction
	{
		[XmlArrayItem("restriction", Namespace = "https://erju.org/ss026")]
		public List<ss026.AxleLoadRestriction> restrictions;
		[XmlAttribute]
		public uint d_axleload_k {get;set;}
		[XmlAttribute]
		public uint l_axleload_k {get;set;}
		[XmlAttribute]
		public bool q_front_k {get;set;}
	}
}