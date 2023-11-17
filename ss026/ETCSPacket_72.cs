using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_72")]
	public class ETCSPacket_72
	{
		[XmlAttribute]
		public ss026.TextClass q_textclass {get;set;}
		[XmlAttribute]
		public bool q_textdisplay {get;set;}
		[XmlAttribute]
		public uint d_textdisplay {get;set;}
		[XmlAttribute]
		public ss026.DisplayOperatingMode m_modetextdisplay {get;set;}
		[XmlAttribute]
		public ss026.DisplayOperatingLevel m_leveltextdisplay {get;set;}
		[XmlAttribute]
		public uint nid_ntc {get;set;}
		[XmlAttribute]
		public uint l_textdisplay {get;set;}
		[XmlAttribute]
		public uint t_textdisplay {get;set;}
		[XmlAttribute]
		public ss026.TextConfirmationType q_textconfirm {get;set;}
		[XmlAttribute]
		public bool q_conftextdisplay {get;set;}
		[XmlAttribute]
		public bool q_textreport {get;set;}
		[XmlAttribute]
		public uint nid_textmessage {get;set;}
		[XmlAttribute]
		public uint nid_c {get;set;}
		[XmlAttribute]
		public uint nid_rbc {get;set;}
		[XmlAttribute]
		public string text {get;set;}
	}
}