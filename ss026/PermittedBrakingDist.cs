using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "permittedBrakingDist")]
	public class PermittedBrakingDist
	{
		[XmlAttribute]
		public uint d_pbd {get;set;}
		[XmlAttribute]
		public bool q_gdir {get;set;}
		[XmlAttribute]
		public uint g_pbdsr {get;set;}
		[XmlAttribute]
		public bool q_pbdsr {get;set;}
		[XmlAttribute]
		public uint d_pbdsr {get;set;}
		[XmlAttribute]
		public uint l_pbdsr {get;set;}
	}
}