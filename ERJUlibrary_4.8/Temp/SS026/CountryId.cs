using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "countryId")]
	public class CountryId
	{		
		[XmlAttribute]
		public uint nid_c;
}