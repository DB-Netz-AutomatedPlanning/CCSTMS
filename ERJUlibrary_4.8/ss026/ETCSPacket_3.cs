using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_3")]
	public class ETCSPacket_3
	{
		[XmlAttribute]
		public uint d_validnv;
		[XmlAttribute]
		public uint nid_c;
		[XmlAttribute]
		public uint nid_c_k;
		[XmlAttribute]
		public uint v_nvshunt;
		[XmlAttribute]
		public uint v_nvstff;
		[XmlAttribute]
		public uint v_nvonsight;
		[XmlAttribute]
		public uint v_nvlimsuperv;
		[XmlAttribute]
		public uint v_nvunfit;
		[XmlAttribute]
		public uint v_nvrel;
		[XmlAttribute]
		public uint d_nvroll;
		[XmlAttribute]
		public bool q_nvsbtsmperm;
		[XmlAttribute]
		public bool q_nvemrrls;
		[XmlAttribute]
		public bool q_nvguiperm;
		[XmlAttribute]
		public bool q_nvsbfbperm;
		[XmlAttribute]
		public bool q_nvinhsmicperm;
		[XmlAttribute]
		public uint v_nvallowovtrp;
		[XmlAttribute]
		public uint v_nvsupovtrp;
		[XmlAttribute]
		public uint d_nvovtrp;
		[XmlAttribute]
		public uint t_nvovtrp;
		[XmlAttribute]
		public uint d_nvpotrp;
		[XmlAttribute]
		public NVContact m_nvcontact;
		[XmlAttribute]
		public uint t_nvcontact;
		[XmlAttribute]
		public bool m_nvderun;
		[XmlAttribute]
		public uint d_nvstff;
		[XmlAttribute]
		public bool q_nvdriver_adhes;
		[XmlAttribute]
		public uint a_nvmaxredadh1;
		[XmlAttribute]
		public uint a_nvmaxredadh2;
		[XmlAttribute]
		public uint a_nvmaxredadh3;
		[XmlAttribute]
		public uint q_nvlocacc;
		[XmlAttribute]
		public uint m_nvavadh;
		[XmlAttribute]
		public uint m_nvebcl;
				public NKV nkvItem;

	}
}
