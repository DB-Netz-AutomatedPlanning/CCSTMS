using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "axleLoadDLRestriction")]
	public class AxleLoadDLRestriction
	{		
		[XmlAttribute]
		public uint d_axleload_k;		
		[XmlAttribute]
		public uint l_axleload_k;		
		[XmlAttribute]
		public bool q_front_k;		
		[XmlArrayItem("axleLoadRestriction", Namespace = "https://erju.org/")]
		public List<AxleLoadRestriction>? restrictions;
}