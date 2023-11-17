using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "pBDSelection")]
	public class PBDSelection
	{
		[XmlArrayItem("pbd", Namespace = "https://erju.org/ss026")]
		public List<ss026.PermittedBrakingDist> pbds;
		public D_trackinitRef? d_trackinit {get;set;}
	}
}