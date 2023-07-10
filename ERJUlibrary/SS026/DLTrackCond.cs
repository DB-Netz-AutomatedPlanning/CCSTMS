using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "dLTrackCond")]
	public class DLTrackCond
	{		
		[XmlAttribute]
		public uint d_trackcond;		
		[XmlAttribute]
		public uint l_trackcond;
}