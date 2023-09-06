using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "trackCondPlatformSelection")]
	public class TrackCondPlatformSelection
	{		
		[XmlArrayItem("tCSPCondition", Namespace = "https://erju.org/")]
		public List<TCSPCondition>? tcspConds;		
		[XmlAttribute]
		public uint d_trackinit;
}