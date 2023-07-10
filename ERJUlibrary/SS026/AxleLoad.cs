using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "axleLoad")]
	public class AxleLoad
	{		
		[XmlAttribute]
		public uint d_axleload;		
		[XmlAttribute]
		public uint l_axleload;		
		[XmlAttribute]
		public bool q_front;		
		[XmlArrayItem("axleLoadDLRestriction", Namespace = "https://erju.org/")]
		public List<AxleLoadDLRestriction>? axleLoadDLRestrictions;
}