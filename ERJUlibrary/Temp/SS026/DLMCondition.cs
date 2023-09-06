using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "dLMCondition")]
	public class DLMCondition
	{		
		[XmlAttribute]
		public uint d_trackcond;		
		[XmlAttribute]
		public uint l_trackcond;		 
		[XmlAttribute]
		public TrackCondType m_trackcond;
}