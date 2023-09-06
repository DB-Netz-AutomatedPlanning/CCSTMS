using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_49")]
	public class ETCSPacket_49
	{		
		[XmlArrayItem("countryBalise", Namespace = "https://erju.org/")]
		public List<CountryBalise>? balises;
}