using System.Xml.Serialization;
using System.Collections.Generic;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "eTCSEngineering")]
	public class ETCSEngineering
	{
		[XmlArrayItem("area", Namespace = "https://erju.org/eng")]
		public List<eng.EngArea> areas;
		[XmlArrayItem("mileageArea", Namespace = "https://erju.org/eng")]
		public List<eng.MileageArea> mileageAreas;
	}
}