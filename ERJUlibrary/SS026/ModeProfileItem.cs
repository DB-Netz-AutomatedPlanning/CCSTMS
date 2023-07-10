using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "modeProfileItem")]
	public class ModeProfileItem
	{		
		[XmlAttribute]
		public uint d_mamode;		
		 
		[XmlAttribute]
		public MAMode m_mamode;		
		[XmlAttribute]
		public uint v_mamode;		
		[XmlAttribute]
		public uint l_mamode;		
		[XmlAttribute]
		public uint l_ackmamode;		
		[XmlAttribute]
		public bool q_mamode;
}