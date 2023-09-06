using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "newCountry")]
	public class NewCountry
	{		
		[XmlAttribute]
		public uint nid_c;
}