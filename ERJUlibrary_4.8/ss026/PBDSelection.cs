using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "pBDSelection")]
	public class PBDSelection
	{
		[XmlArrayItem("pbd", Namespace = "https://erju.org/ss026")]
		public List<PermittedBrakingDist> pbds;
		[XmlAttribute]
		public uint d_trackinit;

	}
}
