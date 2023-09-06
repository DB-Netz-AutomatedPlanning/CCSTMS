using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "lXStatus")]
	public class LXStatus
	{		
		[XmlAttribute]
		public uint v_lx;		
		[XmlAttribute]
		public bool q_stoplx;		
		[XmlAttribute]
		public uint l_stoplx;
}