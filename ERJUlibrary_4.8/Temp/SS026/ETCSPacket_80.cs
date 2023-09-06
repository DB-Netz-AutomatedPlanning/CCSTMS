using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_80")]
	public class ETCSPacket_80
	{		
		[XmlArrayItem("modeProfileItem", Namespace = "https://erju.org/")]
		public List<ModeProfileItem>? modeProfiles;
}