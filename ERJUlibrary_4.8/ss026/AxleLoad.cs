using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "axleLoad")]
	public class AxleLoad
	{
		[XmlAttribute]
		public uint d_axleload;
		[XmlAttribute]
		public uint l_axleload;
		[XmlAttribute]
		public bool q_front;
		[XmlArrayItem("axleLoadDLRestriction", Namespace = "https://erju.org/ss026")]
		public List<AxleLoadDLRestriction> axleLoadDLRestrictions;

	}
}
