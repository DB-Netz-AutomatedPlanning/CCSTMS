using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "permittedBrakingDist")]
	public class PermittedBrakingDist
	{
		[XmlAttribute]
		public uint d_pbd;
		[XmlAttribute]
		public bool q_gdir;
		[XmlAttribute]
		public uint g_pbdsr;
		[XmlAttribute]
		public bool q_pbdsr;
		[XmlAttribute]
		public uint d_pbdsr;
		[XmlAttribute]
		public uint l_pbdsr;

	}
}
