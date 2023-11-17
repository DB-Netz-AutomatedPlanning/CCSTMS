using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "axleLoad")]
	public class AxleLoad
	{
		[XmlArrayItem("axleLoadDLRestriction", Namespace = "https://erju.org/ss026")]
		public List<ss026.AxleLoadDLRestriction> axleLoadDLRestrictions;
		[XmlAttribute]
		public uint d_axleload {get;set;}
		[XmlAttribute]
		public uint l_axleload {get;set;}
		[XmlAttribute]
		public bool q_front {get;set;}
	}
}