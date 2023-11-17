using System.Xml.Serialization;
using System.Collections.Generic;

namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "trainProtection")]
	public class TrainProtection
	{
		[XmlArrayItem("tpAreaItem", Namespace = "https://erju.org/tp")]
		public List<tp.TrainProtectionArea> tpArea;
	}
}