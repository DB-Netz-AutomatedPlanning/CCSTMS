using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "axleLoadRestriction")]
	public class AxleLoadRestriction
	{		
		[XmlAttribute]
		public AxleLoadCategory m_axleloadcat_n;		
		[XmlAttribute]
		public uint v_axleload_n;
}