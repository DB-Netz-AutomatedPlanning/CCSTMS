using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_72")]
	public class ETCSPacket_72
	{
		[XmlAttribute]
		public TextClass q_textclass;
		[XmlAttribute]
		public bool q_textdisplay;
		[XmlAttribute]
		public uint d_textdisplay;
		[XmlAttribute]
		public DisplayOperatingMode m_modetextdisplay;
		[XmlAttribute]
		public DisplayOperatingLevel m_leveltextdisplay;
		[XmlAttribute]
		public uint nid_ntc;
		[XmlAttribute]
		public uint l_textdisplay;
		[XmlAttribute]
		public uint t_textdisplay;
		[XmlAttribute]
		public TextConfirmationType q_textconfirm;
		[XmlAttribute]
		public bool q_conftextdisplay;
		[XmlAttribute]
		public bool q_textreport;
		[XmlAttribute]
		public uint nid_textmessage;
		[XmlAttribute]
		public uint nid_c;
		[XmlAttribute]
		public uint nid_rbc;
		private string text;
		[XmlAttribute(AttributeName = "text")]
		public string Text
		{
			set
			{
				this.text = value;
			}
			get
			{
				return this.text != null?  this.text : "";
			}
}

	}
}
