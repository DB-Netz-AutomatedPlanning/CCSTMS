using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "modeProfileItem")]
	public class ModeProfileItem
	{
		[XmlAttribute]
		public uint d_mamode {get;set;}
		[XmlAttribute]
		public ss026.MAMode m_mamode {get;set;}
		[XmlAttribute]
		public uint v_mamode {get;set;}
		[XmlAttribute]
		public uint l_mamode {get;set;}
		[XmlAttribute]
		public uint l_ackmamode {get;set;}
		[XmlAttribute]
		public bool q_mamode {get;set;}
	}
}