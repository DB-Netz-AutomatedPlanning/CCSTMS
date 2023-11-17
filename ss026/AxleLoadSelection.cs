using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "axleLoadSelection")]
	public class AxleLoadSelection
	{
		public ss026.AxleLoad? axleLoad {get;set;}
		public D_trackinitRef? d_trackinit {get;set;}
	}
}