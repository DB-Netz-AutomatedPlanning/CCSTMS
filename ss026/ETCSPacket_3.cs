using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_3")]
	public class ETCSPacket_3
	{
		public ss026.NKV? nkvItem {get;set;}
		[XmlAttribute]
		public uint d_validnv {get;set;}
		[XmlAttribute]
		public uint nid_c {get;set;}
		[XmlAttribute]
		public uint nid_c_k {get;set;}
		[XmlAttribute]
		public uint v_nvshunt {get;set;}
		[XmlAttribute]
		public uint v_nvstff {get;set;}
		[XmlAttribute]
		public uint v_nvonsight {get;set;}
		[XmlAttribute]
		public uint v_nvlimsuperv {get;set;}
		[XmlAttribute]
		public uint v_nvunfit {get;set;}
		[XmlAttribute]
		public uint v_nvrel {get;set;}
		[XmlAttribute]
		public uint d_nvroll {get;set;}
		[XmlAttribute]
		public bool q_nvsbtsmperm {get;set;}
		[XmlAttribute]
		public bool q_nvemrrls {get;set;}
		[XmlAttribute]
		public bool q_nvguiperm {get;set;}
		[XmlAttribute]
		public bool q_nvsbfbperm {get;set;}
		[XmlAttribute]
		public bool q_nvinhsmicperm {get;set;}
		[XmlAttribute]
		public uint v_nvallowovtrp {get;set;}
		[XmlAttribute]
		public uint v_nvsupovtrp {get;set;}
		[XmlAttribute]
		public uint d_nvovtrp {get;set;}
		[XmlAttribute]
		public uint t_nvovtrp {get;set;}
		[XmlAttribute]
		public uint d_nvpotrp {get;set;}
		[XmlAttribute]
		public ss026.NVContact m_nvcontact {get;set;}
		[XmlAttribute]
		public uint t_nvcontact {get;set;}
		[XmlAttribute]
		public bool m_nvderun {get;set;}
		[XmlAttribute]
		public uint d_nvstff {get;set;}
		[XmlAttribute]
		public bool q_nvdriver_adhes {get;set;}
		[XmlAttribute]
		public uint a_nvmaxredadh1 {get;set;}
		[XmlAttribute]
		public uint a_nvmaxredadh2 {get;set;}
		[XmlAttribute]
		public uint a_nvmaxredadh3 {get;set;}
		[XmlAttribute]
		public uint q_nvlocacc {get;set;}
		[XmlAttribute]
		public uint m_nvavadh {get;set;}
		[XmlAttribute]
		public uint m_nvebcl {get;set;}
	}
}