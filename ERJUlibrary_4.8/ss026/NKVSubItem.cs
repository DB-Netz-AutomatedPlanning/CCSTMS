using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "nKVSubItem")]
	public class NKVSubItem
	{
		public NVP13 nvp13;
		[XmlArrayItem("mvv", Namespace = "https://erju.org/ss026")]
		public List<VMM> mvvs;

	}
}
