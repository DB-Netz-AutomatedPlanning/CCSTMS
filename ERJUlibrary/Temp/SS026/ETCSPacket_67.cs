using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_67")]
	public class ETCSPacket_67
	{		
		[XmlArrayItem("dLTrackCond", Namespace = "https://erju.org/")]
		public List<DLTrackCond>? trackConditions;
}