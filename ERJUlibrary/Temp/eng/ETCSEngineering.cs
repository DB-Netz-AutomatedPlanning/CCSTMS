using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "eTCSEngineering")]
	public class ETCSEngineering
    {
        [XmlArrayItem("engArea", Namespace = "https://erju.org/eng")]
        public List<EngArea>? areas;		
	}
}