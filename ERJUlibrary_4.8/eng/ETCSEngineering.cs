using System.Xml.Serialization;
using System.Collections.Generic;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "eTCSEngineering")]
	public class ETCSEngineering
    {
        [XmlArrayItem("engArea", Namespace = "https://erju.org/eng")]
        public List<EngArea> areas;		
	}
}
