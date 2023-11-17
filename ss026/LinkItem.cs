using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "linkItem")]
	public class LinkItem
	{
		public ss026.CountryId? q_newcountry {get;set;}
		[XmlAttribute]
		public uint d_link {get;set;}
		[XmlAttribute]
		public uint nid_bg {get;set;}
		[XmlAttribute]
		public bool q_linkorientation {get;set;}
		[XmlAttribute]
		public ss026.LinkReaction q_linkreaction {get;set;}
		[XmlAttribute]
		public uint q_locacc {get;set;}
	}
}