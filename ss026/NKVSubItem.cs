using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "nKVSubItem")]
	public class NKVSubItem
	{
		[XmlElement(Order = 0)]
		public ss026.NVP13? nvp13 {get;set;}
		[XmlArrayItem("mvv", Namespace = "https://erju.org/ss026"),XmlArray(Order = 1)]
		public List<ss026.VMM> mvvs;
	}
}