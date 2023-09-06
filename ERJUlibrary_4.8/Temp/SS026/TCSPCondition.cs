using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "tCSPCondition")]
	public class TCSPCondition
	{		
		[XmlAttribute]
		public uint d_trackcond;		
		[XmlAttribute]
		public uint l_trackcond;		 
		[XmlAttribute]
		public PlatformType m_platform;		
		[XmlAttribute]
		public PlatformPosition q_platform;
}