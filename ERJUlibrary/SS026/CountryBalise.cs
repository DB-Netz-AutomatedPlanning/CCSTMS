using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "countryBalise")]
	public class CountryBalise
	{		
		[XmlAttribute]
		public bool q_newcountry_k;		
		[XmlAttribute]
		public uint nid_c_k;		
		[XmlAttribute]
		public uint nid_bg_k;
}