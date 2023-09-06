using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_79")]
	public class ETCSPacket_79
	{		
		[XmlArrayItem("geoPosItem", Namespace = "https://erju.org/")]
		public List<GeoPosItem>? geoPosItems;
}