using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_5")]
	public class ETCSPacket_5
	{		
		[XmlArrayItem("linkItem", Namespace = "https://erju.org/")]
		public List<LinkItem>? links;
}