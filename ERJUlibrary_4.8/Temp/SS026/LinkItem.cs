using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "linkItem")]
	public class LinkItem
	{		
		[XmlAttribute]
		public uint d_link;		
		public CountryId? q_newcountry;		
		[XmlAttribute]
		public uint nid_bg;		
		[XmlAttribute]
		public bool q_linkorientation;
		[XmlAttribute]
		public LinkReaction q_linkreaction;		
		[XmlAttribute]
		public uint q_locacc;
}