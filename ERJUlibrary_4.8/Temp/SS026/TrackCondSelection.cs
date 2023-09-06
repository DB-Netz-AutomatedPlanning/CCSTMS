using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "trackCondSelection")]
	public class TrackCondSelection
	{		
		[XmlArrayItem("dLMCondition", Namespace = "https://erju.org/")]
		public List<DLMCondition>? dlmConds;		
		[XmlAttribute]
		public uint d_trackinit;
}