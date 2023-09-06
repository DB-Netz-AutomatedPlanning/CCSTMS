using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_80")]
	public class ETCSPacket_80
	{
		[XmlArrayItem("modeProfile", Namespace = "https://erju.org/ss026")]
		public List<ModeProfileItem> modeProfiles;

	}
}
